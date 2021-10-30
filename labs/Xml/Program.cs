using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Xml
{
  class Program
  {
    static void Main(string[] args)
    {
      string sFn = @"DATA\SfoMqVtb.xml";
      // h_DOM(sFn);
      h_SAX(sFn);
      h_XmlSerialize(sFn);
      Console.WriteLine("...");
      Console.ReadKey();
    }

    private static void h_XmlSerialize(string sFn)
    {
      // TODO..
    }

    private static void h_SAX(string sFn)
    {
      CParamList pList = new CParamList();
      // read...
      // write...
    }

    private static void h_DOM(string sFn)
    {

      CParamList pList = new CParamList();

      XmlDocument pDocument = new XmlDocument();
      pDocument.Load(sFn);
      XmlNodeList pChilds = pDocument.ChildNodes;
      foreach (XmlNode pChild in pChilds) {
        string sParent = pChild.Name;
        foreach (XmlNode pSubChild in pChild.ChildNodes) {
          CParam pParam = new CParam();
          var pKeyNode = pSubChild.SelectSingleNode("Key");
          var pValueNode = pSubChild.SelectSingleNode("Value");
          pParam.Name = pKeyNode.InnerText;
          pParam.Value = pValueNode.InnerText;

          pList.Add(pParam);
        }
      }


      XmlDocument pOutDocument = new XmlDocument();
      pOutDocument.LoadXml("<root />");
      XmlNodeList pNodeList = pOutDocument.ChildNodes;
      XmlNode pParent = pNodeList[0];

      foreach (var pParam in pList) {
        Console.WriteLine($"{pParam.Name} = {pParam.Value}");
        XmlElement pParamNode = pOutDocument.CreateElement("Param");
        XmlAttribute pAttrName = pOutDocument.CreateAttribute("name");
        XmlAttribute pAttrValue = pOutDocument.CreateAttribute("value");
        pAttrName.Value = pParam.Name;
        pAttrValue.Value = pParam.Value;
        pParamNode.Attributes.Append(pAttrName);
        pParamNode.Attributes.Append(pAttrValue);

        pParent.AppendChild(pParamNode);
      }
      pOutDocument.Save(sFn + ".domxml");

    }
  }

  public class CParamList: List<CParam>
  {

  }

  public class CParam
  {
    public string Name;
    public string Value;
  }
}
