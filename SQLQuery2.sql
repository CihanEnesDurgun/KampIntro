--Select
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City = 'Berlin'
--şehri londra olanları getir*

Select * from Products where categoryId=1 or CategoryID = 3
--ürünler tablosunu tüm sutunlarıyla getir

Select * from Products where categoryId=1 and UnitPrice>=10

select * from Products where CategoryID=1 order by UnitPrice desc
--ürünleri fiyata göre sırala*
--asc/ascending= artan*
--desc/descending= düşen/azalan*

select count(*) from Products where CategoryID=2
--bütün ürünler grubunda kaç ürün var bunu gösterir. ayrıca son ekediğimiz kısımda da kategori Id'si 2 olan kaç tane ürün olduğunu gösterir.
select categoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10
--verimi filtrele, categoryId ye göre sırala, sayısı 10dan küçük olsun , fiyati 20'nin üstünde olsun

----------------------------------------------------------------------------------------------

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from products inner join Categories
on Products.CategoryId = Categories.CategoryID
where Products.UnitPrice>10

--hem ürün hem katagorilerin bir araya getirilmiş türü.
--DTO / Data Transformation Object
--inner join sadece iki tablo da da eşleşen dataları getirir.

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID
--solda olup sağda olmayanları da getir* = left join

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null