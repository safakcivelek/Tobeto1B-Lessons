--JOIN
--Hangi ürün hangi kategoride
Select p.product_name,c.category_name from products p inner join categories c on p.category_id = c.category_id

--Hangi siparişin hangi kargo şirketi ile ne zaman gönderilmiş
Select o.order_id, s.company_name,o.order_date from orders o inner join shippers s ON o.ship_via = s.shipper_id

--Hangi siparişi,hangi çalışan, hangi müşteri vermiştir?
--orders, employees,customers
--|| ile birleştirme yapılır.
Select o.order_id,e.first_name || ' ' || e.last_name as "AD-SOYAD", c.company_name from orders o
inner join employees e on o.employee_id = e.employee_id
inner join customers c on o.customer_id = c.customer_id

--Sipariş alan çalışanlarım
Select e.first_name || ' ' || e.last_name as "AD-SOYAD",o.order_id,o.order_date from employees e
left join orders o on e.employee_id = o.order_id


Select o.order_id, o.order_date, e.first_name || ' ' || e.last_name as "AD-SOYAD",o.order_id from orders o
right join employees e on e.employee_id = o.employee_id order by order_date desc

--Sorgumuzda tüm müşteriler ve verdikleri siparişlerin tarhileri
Select c.company_name,o.order_date from orders o
right join customers c on c.customer_id = o.customer_id order by order_date desc

--Group by
--Belirtilen sütun ya da sütunlaradaki aynı değere sahip satırları gruplar
--Sipariş detayları tablosundan productid alanına göre gruplandıralım ve her grubun toplam sipariş miktarını belirtelim
Select product_id,SUM(quantity) from order_details
group by product_id

--Hangi kategoride toplam kaç ürün var?
Select count(p.category_id), c.category_name from products p
inner join categories c on p.category_id = c.category_id
group by c.category_name

--Hangi ülkeye ne kadarlık satış yapılmış?
Select c.country,SUM(od.quantity * od.unit_price) from customers c 
inner join orders o on c.customer_id = o.customer_id
inner join order_details od on o.order_id = od.order_id
group by c.country

--HAVING
--where gibi görev ve işlev bakımımdan benzer.
--Toplam sipariş miktarı 1300 adetten fazla olan ürün kodları
Select product_id,SUM(quantity) as total_quantity from order_details
group by product_id
having SUM(quantity) > 1300

--Stok sayısı 20 den fazla, toplam ürün sayısı da 1'den fazla ürünler
Select category_id,units_in_stock,count(*) from products
where units_in_stock > 20
group by category_id,units_in_stock
having count(*) > 1

--İçerisinde en az 2 ürün olan kategorilerin ürün sayısı
Select category_name,count(*) as "Kategoride ki ürün sayısı" from products
inner join categories on categories.category_id = products.category_id
group by category_name
having count(*) >= 10

--10 adetten fazla satılan ürünler	
Select product_name,SUM(quantity) as "Toplam Sipariş Miktarı" from order_details od
inner join products p on od.product_id = p.product_id
group by product_name
having sum(quantity) > 200