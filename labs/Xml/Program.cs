using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Xml
{
  class Program
  {
    static void Main(string[] args)
    {
      string sFn = @"DATA\SfoMqVtb.xml";
      // h_DOM(sFn);
      // h_SAX(sFn);
      //h_XmlSerialize(sFn);
      h_Json(sFn);
      Console.WriteLine("...");
      Console.ReadKey();
    }

    private static void h_Json(string sFn)
    {
      CParamList pList = new CParamList();
      h_ReadParamList(sFn, pList);
      // 1. Упрощенный вариант:
      // string sLine = JsonConvert.SerializeObject(pList);
      // File.WriteAllText(sFn + ".json", sLine, Encoding.UTF8);

      // 2. Более гибкий вариант:
      JsonSerializer ser = new JsonSerializer();
      using (StreamWriter pSw = new StreamWriter(sFn + ".json")) {
        using (JsonWriter pJ = new JsonTextWriter(pSw)) {
          pJ.Formatting = Newtonsoft.Json.Formatting.Indented;
          ser.Serialize(pJ, pList);
        }
      }

      // десериализация
      CParamList pRes = JsonConvert.DeserializeObject<CParamList>(File.ReadAllText(sFn + ".json", Encoding.UTF8));
    }

    private static void h_XmlSerialize(string sFn)
    {
      CParamList pList = new CParamList();
      h_ReadParamList(sFn, pList);

      // DataContractSerializer
      // сериализация
      DataContractSerializer pS = new DataContractSerializer(typeof(CParamList));
      using (Stream pOutStream = File.Create(sFn + ".DataContractSerializer")) {
        pS.WriteObject(pOutStream, pList);
      }
      pList.Clear();
      // десериализация
      using (Stream pOutStream = File.OpenRead(sFn + ".DataContractSerializer")) {
        pList = (CParamList)pS.ReadObject(pOutStream);
      }

      // XmlSerializer
      // сериализация
      XmlSerializer pXml = new XmlSerializer(typeof(CParamList));
      using (Stream pOutStream = File.Create(sFn + ".XmlSerializer")) {
        pS.WriteObject(pOutStream, pList);
      }
      pList.Clear();
      // десериализация
      using (Stream pOutStream = File.OpenRead(sFn + ".XmlSerializer")) {
        CParamList pNewList = (CParamList)pS.ReadObject(pOutStream);
      }


      // XmlSerializer + custom nodes
      //CRoot pRoot = new CRoot() {
      //  Items = pList
      //};
      //// XmlSerializer
      //// сериализация
      //// !TODO!: //
      //XmlSerializer pXml = new XmlSerializer(typeof(CRoot));
      //using (Stream pOutStream = File.Create(sFn + ".XmlSerializer")) {
      //  pS.WriteObject(pOutStream, pRoot);
      //}
      //pList.Clear();
      //// десериализация
      //using (Stream pOutStream = File.OpenRead(sFn + ".XmlSerializer")) {
      //  CRoot pRoot2 = (CRoot)pS.ReadObject(pOutStream);
      //  pList = pRoot2.Items;
      //}


    }

    private static void h_SAX(string sFn)
    {
      CParamList pList = new CParamList();
      h_ReadParamList(sFn, pList);

      // !TODO!: //
      //CParamList pList = new CParamList();
      //using (Stream pInStream = File.OpenRead(sFn)) {
      //  using (XmlTextReader reader = new XmlTextReader(pInStream)) {
      //    while (!reader.EOF) {
      //      reader.ReadStartElement();
      //      string pElementName = reader.Name;
      //      XmlNodeType pElementType = reader.NodeType;
      //      if (pElementType == XmlNodeType.Whitespace) continue;
      //      reader.ReadEndElement();
      //    }
      //  }
      //}

      // write...

      using (Stream pOutStream = File.Create(sFn + ".saxxml")) {
        using (XmlTextWriter writer = new XmlTextWriter(pOutStream, Encoding.UTF8)) {
          writer.Formatting = System.Xml.Formatting.Indented;
          writer.WriteStartDocument();
          h_WriteList(pList, writer, "root");
          writer.WriteEndDocument();
        }

      }
    }

    private static void h_WriteList(CParamList pList, XmlTextWriter writer, string sNodeName)
    {
      writer.WriteStartElement(sNodeName);
      foreach (CParam pEl in pList) {
        // for (int ii = 0; ii < 99999; ii++) {
          h_AddParam(writer, pEl);
        // }
      }
      writer.WriteEndElement();
    }

    private static void h_AddParam(XmlTextWriter writer, CParam pEl)
    {
      writer.WriteStartElement("Param");
      writer.WriteAttributeString("name", pEl.Name);
      writer.WriteAttributeString("value", pEl.Value);
      writer.WriteEndElement();
    }

    private static void h_DOM(string sFn)
    {

      CParamList pList = new CParamList();
      h_ReadParamList(sFn, pList);

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

    private static void h_ReadParamList(string sFn, CParamList pList)
    {
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
    }
  }

  [XmlRoot("root")]
  public class CRoot
  {
    [XmlArray("root"), XmlArrayItem("Param")]
    public CParamList Items;

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
