using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using PuppeteerSharp;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

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
            CargarNoticias();
        }

        private void listBoxNews_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            List<String> url = new List<String>();
            HtmlWeb oWeb = new HtmlWeb();
            HtmlDocument doc = oWeb.Load("https://cnnespanol.cnn.com/seccion/tecnologia/");


            foreach (var Nodo in doc.DocumentNode.CssSelect(".news__title"))
            {

                var NodoAnchor = Nodo.CssSelect("a").FirstOrDefault();
                String linkCrudo = NodoAnchor.OuterHtml;
                String[] link = linkCrudo.Split(' ');

                string linkFinal = link[1];

                string searchString = "https";
                int startIndex = linkFinal.IndexOf(searchString);
                searchString = "https" + searchString.Substring(1);
                int endIndex = linkFinal.Length + 1;
                String substring = linkFinal.Substring(startIndex, endIndex - searchString.Length);
                url.Add(substring);

            }

            var navegador = new ProcessStartInfo(@"C:\Program Files\Google\Chrome\Application\chrome.exe");
            navegador.Arguments = url.ElementAt(listBoxNews.SelectedIndex);
            Process.Start(navegador);
        }
    }
}
