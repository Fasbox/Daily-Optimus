using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuppeteerSharp;

namespace TrackerUI
{
    public partial class NoticiasForm : Form
    {
        public NoticiasForm()
        {
            InitializeComponent();
        }



        private async void CargarNoticias()
        {
            string url = "https://cnnespanol.cnn.com/seccion/tecnologia/";
            string chrome = @"C:\Program Files\Google\Chrome\Application\chrome.exe";


            using var browserFetcher = new BrowserFetcher();
            await browserFetcher.DownloadAsync();

            await using var browser = await Puppeteer.LaunchAsync(
                    new LaunchOptions
                    {
                        Headless = true,
                        ExecutablePath = chrome,
                    }
                );

            await using var page = await browser.NewPageAsync();

            await page.GoToAsync(url);

            List<String> titles = new List<String>();

            var result = await page.EvaluateFunctionAsync("()=>{" +
                "const a = document.querySelectorAll('.news__title');" +
                "const res = [];" +
                "for(let i=0; i<a.length; i++)" +
                "   res.push(a[i].innerText);" +
                "return res;" +
                "}");

            foreach (var e in result)
                titles.Add(e.ToString());

            foreach (var e in titles)
                listBoxNews.Items.Add(e);
        }

        private void NoticiasForm_Load(object sender, EventArgs e)
        {
            CargarNoticias ();
        }
    }
}
