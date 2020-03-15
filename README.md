# LinqToXml-demo
Example
------
***
- With file.xml:
```xml
   <?xml version='1.0'?>
   <!-- database -->
   <channel>
     <item>
       <title>The Autobiography of Benjamin Franklin</title>
       <author>
         <first-name>Benjamin</first-name>
         <last-name>Franklin</last-name>
       </author>
     </item>
   </channel>
```
***
* Use Linq to Xml:
```C#
var xdoc = XDocument.Load("file.xml");
var titles = from i in xdoc.Root.Element("channel").Elements("item")
             select (string)i.Element("title");
```

* Use XPath:
```C#
var titles = xdoc.XPathSelectElements("rss/channel/item/title")
                 .Select(t => (string)t);
```

| Expression   | Description                                                          |
|:------------:|:--------------------------------------------------------------------:|
| nodename     | Selects all nodes with the name "nodename"                           |
| /            | Selects from the root node                                           |
| //           | Selects nodes in the document from the current node that match the   |
|              |   selection no matter where they are                                 |
| .            | Selects the current node                                             |
| ..           | Selects the parent of the current node                               |

> [more](https://www.w3schools.com/xml/xpath_syntax.asp)

* XQuery(Saxon):
```C#
for $x in /order/item return $x/price * $x/quantity
```
```
<pricing>
for $x in doc("NorthWind.xml")/order/item
where $x/price>
```
