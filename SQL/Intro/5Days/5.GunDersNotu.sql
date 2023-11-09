-- SQL => Structured Query Language

--SELECT
--Select [kolonlar] from [tablo_adi]
--* => tüm kolonlar
Select product_name , unit_price from products;

--WHERE
--'den anlamı katar
--Alias => Takma ad
--Select * from products where unit_price > 20
Select product_name as "Ürün adı", unit_price as "Ürün Fiyatı" from products 
where unit_price > 20;

--AND ifadesi
Select * from products where unit_price >= 100 AND unit_price <= 200
--BETWEEN ifadesi
Select * from products where unit_price Between 100 AND 200
--OR ifadesi
Select * from products where unit_price > 20 OR units_in_stock > 15

--IN()
--İçerisine aldığı parametre olarak verilen n kadar veri ile ilgili alanların uyuşmasını sağlar.
Select * from products where LOWER(product_name) IN('chai', 'chang', 'ikura')

Select * from products where category_id IN(1,2)

--LIKE
--pattern => kalıba benzer ifadeleri gösterir.
--% => ilgili metnin sağına ya da soluna eklendiğinde metinden önce veya sonrasında gelecek 
--metni önemsediğini söyler.
-- _ => karakter atlamasını gösterir.
Select * from products where product_name LIKE '%te%'

Select * from products where LOWER(product_name) LIKE 'te%'

Select * from products where LOWER(product_name) LIKE '__r%'

--Built-in Functions
--Summary => Toplama
Select SUM(unit_price) from products

--Average => Ortalama
Select AVG(unit_price) from products

--Maxiumum => Maksimum değeri döndürür.
Select MAX(unit_price) from products

--Minimum => Minimum değerei döndürür.
Select MIN(unit_price) from products

--Kaç farklı şehirde çalışanım var?
--DISTINCT => tekrarı engeller.
Select * from employees
Select DISTINCT city from employees

--DATE
--Bugünün tarihini yazdırma
Select current_date

--interval
Select date_part('month',current_date)

--DATEDIFF(interval,date1,date2).Hazır fonksiyondur.İki tarih arası farkı verir.
Select first_name, EXTRACT(year FROM AGE(CURRENT_DATE, birth_date)) from employees

--Son 10 gün içerisindeki siparişler
Select * from orders where date_part('year', current_date) = date_part('year',order_date)
AND date_part('month', current_date) = date_part('month',order_date)
AND date_part('day', current_date) - date_part('day',order_date) < 10

--SUB-QUERY -> İç içe sorgular
--Ortalamanın altında bir fiyata sahip olan ürünler
Select AVG(unit_pice) from products

Select product_name,unit_price from products

Select product_name,unit_price from products
where unit_price < (Select AVG(unit_price) from products)

--En pahalı ürünün bilgilerini getirme
Select MAX(unit_price) from products 
Select * from products where unit_price = 263.5

Select * from products where unit_price = (Select max(unit_price) from products)

--ORDER BY => Sıralama
--default => küçükten büyüğe
--ascending => asc küçükten büyüğe
--descening => desc büyükten küçüğe
Select product_name,unit_price from products ORDER BY unit_price desc LIMIT 1


