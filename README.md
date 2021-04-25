# Billing-Now
### A simple billing system for any small retail shop
This project has many incomplete requirements and the end product is objectively flawed. I followed the instructions to the best of my abilities, but had to make compromises in some areas in order to mimic the intended output. The purpose of this project was to test my ability to fullfil different needs and requirements. 
## Contributing 
Pull requests are welcome. You can check out the project and make your own alterations. But I would suggest going on Youtube and watch [Vijay Thapa's](https://www.youtube.com/watch?v=Lttd3ohTarE&list=PLBLPjjQlnVXVnz3Hksi1th0uHXxh6Dm3h) playlist on making a proper billing system in C#. 
## Given Instructions 
### Description (Word to word of what I was given)
The project is intended to be used in any small retail shops that requires a billing system. The purpose is to have an easy and user-friendly system to allow place order for the item there in shop and get the bill. A bill will begenerated with total amount to be paid and Payment will be done in cash.The main functionality is to generate bill , get the data from database.
### Forms Required:
* Customer Details
* Add Item
* Order Summery
### Functionality:
* Items in drop Down will be inserted from table
* New row is inserted when user adds an item to order table.
### Database Structure:
The database consist of Three tables :
* Customer Table: (customerId(pk) , name, mobile)
* Product Table: (productid (pk) , productName , Price)
* Order Table : (orderId(pk) , productid(fk) , totalprice , quantity)

