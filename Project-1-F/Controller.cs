using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Project_1_F {
    class Controller {
        public string Find(XmlDocument xDoc, string word) {
            XmlElement xRoot = xDoc.DocumentElement;
            string result = "Не найдено";
            bool take = false;
            try {
                foreach (XmlNode node in xRoot) {
                    foreach (XmlNode child in node.ChildNodes) {
                        if (child.Name == "ru" && child.InnerText.ToLower() == word.ToLower()) {
                            take = true;
                            result = word.ToUpper();
                        }
                        if (child.Name == "en1" && take) {
                            result += "\n\nПервое значение:\n" + child.InnerText;
                        }
                        if (child.Name == "en2" && take) {
                            result += "\n\nОстальные значения:\n" + child.InnerText;
                            take = false;
                        }
                    }
                }
            } catch(Exception e) {
                result = "Исключение: " + e.Message;
                result += "\n\nГде? " + e.StackTrace;
            }
            return result;
        }
        public string Remove(XmlDocument xDoc, string word, string path) {
            XmlElement xRoot = xDoc.DocumentElement;
            string result = "Элемент удален";
            try {
                foreach (XmlNode node in xRoot) {
                    foreach (XmlNode child in node.ChildNodes) {
                        if (child.Name == "ru" && child.InnerText.ToLower() == word.ToLower()) {
                            xRoot.RemoveChild(node);
                            xDoc.Save(path);
                        }
                    }
                }
            } catch (Exception e) {
                result = "Исключение: " + e.Message;
                result += "\n\nГде? " + e.StackTrace;
            }
            return result;
        }
    }
}
