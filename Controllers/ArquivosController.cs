using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace Cap03N.Controllers
{
    public class ArquivosController : Controller
    {        
        public ActionResult Foto()
        {
            var Arq = Server.MapPath("/Arqs/FundoWin10.jpg");

            return base.File(Arq, "image/jpeg");
        }

        public ActionResult Doc()
        {
            var Arq = Server.MapPath("/Arqs/Apostila.pdf");

            return base.File(Arq, "application/pdf");
        }

        public string ValorXML()
        {
            string sCaminho = Server.MapPath("/Arqs/Dados.xml");

            XmlDocument Doc = new XmlDocument();
            Doc.Load(sCaminho);

            XmlNodeList Lista = Doc.GetElementsByTagName("Aluno");

            string sNomes = "";

            foreach (XmlNode Item in Lista)
                sNomes += Item["nome"].InnerText + "  -  ";

            return sNomes;
        }
    }
}





