using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Windows.Forms;
using YemenWhatsApp.Data;
using Microsoft.EntityFrameworkCore;

namespace YemenWhatsApp
{
    internal static class Program
    {
        private static Mutex _appMutex;

        [STAThread]
        static void Main()
        {
      
         
            // منع تشغيل أكثر من نسخة
            _appMutex = new Mutex(true, "YemenWhatsApp_2.0", out bool isNewInstance);

            if (!isNewInstance)
            {
                MessageBox.Show("❗ التطبيق يعمل بالفعل!\nيمكنك فتح نافذة واحدة فقط من Yemen WhatsApp.",
                    "Yemen WhatsApp",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ApplicationConfiguration.Initialize();

            try
            {
                var hostBuilder = Host.CreateDefaultBuilder();

                hostBuilder.ConfigureServices((context, services) =>
                {
                    // تسجيل DbContext
                    services.AddDbContext<ChatDbContext>(options =>
                        options.UseSqlServer(GetConnectionString()));

                    // تسجيل الخدمات
                    services.AddSingleton<Services.ApiService>();
              
                    services.AddSingleton<Form1>();
                });

                var host = hostBuilder.Build();

                // تهيئة التطبيق
                InitializeApplication(host);

                // تشغيل النموذج الرئيسي
                Application.Run(host.Services.GetRequiredService<Form1>());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ خطأ فادح في بدء التطبيق:\n{ex.Message}",
                    "خطأ فادح",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _appMutex?.ReleaseMutex();
                _appMutex?.Dispose();
            }
        }

        static string GetConnectionString()
        {
            // خيارات متعددة للاتصال بقاعدة البيانات
            string[] connectionStrings =
            {
                @"Server=(localdb)\MSSQLLocalDB;Database=YemenChatDB;Trusted_Connection=True;TrustServerCertificate=True;",
                @"Server=.\SQLEXPRESS;Database=YemenChatDB;Trusted_Connection=True;TrustServerCertificate=True;",
                @"Server=localhost;Database=YemenChatDB;Trusted_Connection=True;TrustServerCertificate=True;",
                @"Server=DESKTOP-2U7RVGF;Database=YemenChatDB;Trusted_Connection=True;TrustServerCertificate=True;"

            };

            return connectionStrings[1]; // استخدام LocalDB افتراضياً
        }

        static void InitializeApplication(IHost host)
        {
            using var scope = host.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<ChatDbContext>();

            try
            {
                // إنشاء قاعدة البيانات
                dbContext.Database.EnsureCreated();

                // تهيئة الإعدادات
                Services.LocalStorage.SaveSetting("AppVersion", "2.0.0");
                Services.LocalStorage.SaveSetting("FirstRun", DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"فشل تهيئة التطبيق:\n{ex.Message}",
                    "خطأ التهيئة",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
