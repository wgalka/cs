# Zadania
Celem laboratorium jest stworzenie uproszczonej biblioteki do zapisu danych w formacie XML.

## Zadanie 1
Utwórz klasę reprezentującą uproszczony Dokument w formacie XML.

Klasa Document zawiera informacje o
- wersji i kodowaniu pliku
- Korzeniu dokumentu

korzeń dokumentu będzie obiektem klasy Element. Klasa ta będzie odpowiadać znacznikowi XML.
![](https://ks.pl/gfx/uploads/blog/103/budowa-znaczniki-html.jpg)
Utwórz klasę Element wykorzystując odpowiednie kolekcje (
https://learn.microsoft.com/pl-pl/dotnet/api/system.collections.generic?view=net-7.0)
- Znacznik może zawierać wiele innych znaczników (Elementów)
- Znacznik może mieć wiele atrybutów

## Zadanie 2
Utwórz interfejsy:
- XMLWriterFactory
    - createXMLWriter()

- XMLWriter
    - writeStartDocument()
    - writeStartElement(name: string)
    - writeAttribute(name: string, value: string)
    - writeEndElement()
    - writeEndDocument()
    - save(filename: string)

Utwórz klasy konkretne implementujące odpowiednie interfejsy:
- CustomXMLWriterFactory : XMLWriterFactory
- CustomXMLWriter : XMLWriter
    - klasa zawiera Dokument
    - klasa zawiera aktualnie tworzony znacznik


## Zadanie 3

Przetestuj działanie zaimplementowanej biblioteki tworząc następującą strukturę XML.

```XML
<?xml version="1.0" encoding="UTF-8"?>
<bookstore>
   <book category="COOKING">
      <title>Everyday Italian</title>
      <author>Giada De Laurentiis</author>
      <year>2005</year>
      <price>30.00</price>
   </book>
   <book category="CHILDREN">
      <title>Harry Potter</title>
      <author>J.K. Rowling</author>
      <year>2005</year>
      <price>29.99</price>
   </book>
   <book category="WEB">
      <title>Learning XML</title>
      <author>Erik T. Ray</author>
      <year>2003</year>
      <price>39.95</price>
   </book>
</bookstore>
```
Przetestuj działanie metody zapisującej obiekt XML.