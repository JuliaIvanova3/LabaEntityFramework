using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReviewsDataEF
{
    public class Class1
    {
    }
     public static class CreateXml
    {
        static public void Create(IQueryable <REVIEW> rEVIEWs, string path)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement xmlElement;

            int child_counter;

            xmlDocument.AppendChild(xmlDocument.CreateXmlDeclaration("1.0", "utf-8", null));
            xmlElement = xmlDocument.CreateElement("DataBasaTable");
            xmlDocument.AppendChild(xmlElement);

            if (rEVIEWs == null)
            { }
                for (child_counter = 0; child_counter < rEVIEWs.ToList().Count;child_counter++)
                {
                    XmlElement idReview;
                    XmlAttribute professor;
                    XmlAttribute student;
                    XmlAttribute rate;
                    XmlAttribute info;
                    idReview = xmlDocument.CreateElement("Review");
                    professor = xmlDocument.CreateAttribute("Professor");
                    professor.Value = rEVIEWs.ToList()[child_counter].PROFESSOR.NAME_PROFESSOR;
                    student = xmlDocument.CreateAttribute("Student");
                    student.Value = rEVIEWs.ToList()[child_counter].STUDENT.NAME_STUDENT;
                    rate = xmlDocument.CreateAttribute("Rate");
                    rate.Value = rEVIEWs.ToList()[child_counter].RATE.MARKS_RATE.ToString();
                    info = xmlDocument.CreateAttribute("Info");
                    info.Value = rEVIEWs.ToList()[child_counter].INFO_REVIEW;

                    idReview.Attributes.Append(professor);
                    idReview.Attributes.Append(student);
                    idReview.Attributes.Append(rate);
                    idReview.Attributes.Append(info);

                    xmlElement.AppendChild(idReview);

                }
                xmlDocument.Save(path);
                return;
            
        }
    }
}
