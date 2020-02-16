# ISAD251 - Database Application Development COURSEWORK 01

## Linked YouTube video (of using this database application)
[![Linked YouTube video (of the using the database application)](http://img.youtube.com/vi/YOUR_YOUTUBE_VIDEO.jpg)](http://www.youtube.com/watch?v=YOUR_YOUTUBE_VIDEO)

## Screenshots of the application

Following screens shows the core basic functions of this application.
### Customer
#### Home Page
The Home page contain the information, such as pictures, opening hours and locations of the pub.
![](/screens/customer/001Home.JPG)

#### Drink Menu
The customer click "Drink" on the navigation bar to view the Drink Menu.
![](/screens/customer/002Drinks.JPG)

#### Order a Drink
The customer click "Add to order" next to the drink to order that drink.
![](/screens/customer/002DrinksAddItemToOrder.JPG)

#### Snack Menu
The customer click "Snack" on the navigation bar to view the Snack Menu.
![](/screens/customer/003Snacks.JPG)

#### Order a Snack
The customer click "Add to order" next to the snack to order that snack.
![](/screens/customer/003SnacksAddItemToOrder.JPG)

#### View Ordered Items
The customer click "Review Ordered Item" to view the ordered item.
![](/screens/customer/004ViewOrderedItems.JPG)

#### Remove Ordered Items
The user simply click "Remove from cart" to remove the ordered item before placing the order.
![](/screens/customer/004ViewOrderedItemsRemoved.JPG)

### Admin
#### Login Page
The admin login the same site and admin functions will be displayed.
![](/screens/admin/001AdminLogin.JPG)

#### Drink or Snack Menu
The admin click the "Drink" or "Snack" Menu from the navigation bar to view the list of items.
![](/screens/admin/002Admin00ItemMenu.png)

### Input Item Details
The admin click "Create" to input item details for sale.
![](/screens/admin/002Admin01InputItemDetails.JPG)

### Read Item Details
The admin click "Detail" next to the item to view the details of that item.
![](/screens/admin/002Admin02ViewItemDetails.JPG)

### Edit Item Details
The admin click "Edit" next to the item to edit the details of that item.
![](/screens/admin/002Admin03EditItemDetails.JPG)

### Remove Item from sale
The admin click "Delete" next to the item to remove that item from sale.
![](/screens/admin/003AdminRemoveItem.JPG)

### View Customer Order(s)
The admin click "Customer Orders" on the navigation bar to view customers' order(s).
![](/screens/admin/004AdminViewOrder.JPG)

### Search a Customer Order(s)
The admin enter the username of a customer in the search box and then click "Search" to view the order(s) of that customer.
![](/screens/admin/004AdminViewOrderOfUser.JPG)

## Application fact sheet
This is an application is designed for the licensed premises, namely IvanPub, selling alcohol and bar snacks.  This application provides the ability for a customer to order drinks and snacks along with an admin user to enter the details of drinks and snacks for sale.  The design of this application is based on the following nine user stories to provide the basic requirements:
1.	A customer would like to order a drink/snack.
1.	A customer would like to view what he/she has ordered.
1.	A customer would like to add drink/snack to his/ her current order.
1.	A customer would like to cancel my order for a drink/snack.
1.	An admin would like to enter details of the drinks/snacks for sale.
1.	An admin would like to read the details of the drinks/snacks for sale.
1.	An admin would like to view a customer’s order(s).
1.	An admin would like to edit the details of the drinks/snacks for sale.
1.	An the admin would like to withdraw a drink/snack from sale.

This is a minimum viable product (MVP) but not a full system.  Only the above user stories provided above are implemented.  The following three aspects are outside of the scope of the system:
1.	Payments that the customer paying for their order is not required.
1.	Delivering the order that the customer receiving their order is not required.
1.	Other users that no other user stories for other users are required.

### FIVE key features
1. Allow customer to order a drink/snack.
1. Allow customer to view what they have selected for their order.
1. Allow customer to add/ remove item in their order.
1. Allow admin to add, edit, or remove drinks/ snacks for sale.
1. Allow admin to view customer’s orders.

This database driven application is a simple three tier application having a simple browser-based client, middleware coded in a server-side language of C# and a database contained in a Microsoft SQL database.


### Prerequisites

run command update-datebase in the package manager console before running the application.

### testing

Following two accounts are seeded in the database for testing:

## admin
username: admin@IvanPub.co.uk\
password: admin251

## customer
username: customer@IvanPub.co.uk\
password: pass251
