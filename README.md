# hyacinthuslux🌸
The Hyacinthus Lux project is a user-friendly application designed to manage client and product information for a flower shop.
It includes essential functionalities for:

#### Data Management: Easily add, update, and delete client and product details.
#### Data Validation: Ensure the accuracy and completeness of information entered.
#### Serialization: Save and load data in different formats.
#### Reporting: Generate and export reports.
#### Graphical Representation: Display data in charts for better visualization.
This application helps streamline business operations, making it easier to keep track of clients and products effectively.
## Class: Client
##### Purpose: Represents the customers of the flower shop, storing their personal and contact information.

##### Attributes
clientId: An integer that serves as the unique identifier for each client.
clientFirstName: A string storing the first name of the client.
clientLastName: A string storing the last name of the client.
clientEmail: A string storing the email address of the client.
clientAddress: A string storing the physical address of the client.
clientPhoneNumber: A string storing the client's phone number.
clientLoyaltyPoints: A double representing the loyalty points accumulated by the client.

##### Properties
FullName: A read-only string property that combines the first and last names of the client.
![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/68737645-6abe-4d0b-912f-2832682ca433)

##### Constructors
1) Parameterized Constructor: Initializes a new instance of the Client class with all attributes,
including validation for the address and phone number. Throws exceptions for invalid values.
2) Parameterless Constructor: Initializes a new instance of the Client class without setting any attributes.

##### Methods
1) CompareTo: Compares the current client object with another client object based on their clientId. This is used for sorting and comparing clients.
2) ToString: Returns a string representation of the client, typically their full name.

##### Custom Exceptions
1) InvalidAddressException: Thrown when the client's address contains the word "Florida".
   ![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/eb9a14ac-9fef-4887-9bef-88c9c2561ecd)
2) General Exception: Thrown for a specific invalid phone number.


### Class: Product
Purpose: Represents the products available in the flower shop, storing details such as price, name, availability, type, and stock.

##### Attributes
productPrice: A decimal representing the price of the product.
productName: A string storing the name of the product.
IsAvailable: A boolean indicating whether the product is available for purchase.
productType: An enumeration (FlowerEnum) specifying the type of flower the product is associated with.
productStock: An integer representing the quantity of the product in stock.

##### Properties
The attributes themselves serve as properties due to the use of auto-implemented properties in C#.

##### Constructors
Parameterless Constructor: Initializes a new instance of the Product class without setting any attributes.
Parameterized Constructor: Initializes a new instance of the Product class with specified values for price, name, availability, type, and stock.

##### Methods
Clone: Implements the ICloneable interface to create a copy of the current product instance. This method returns an object that is a clone of the current instance.
![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/3efc3210-0b34-4cdc-be3f-6bec48392cb0)

##### Enum: FlowerEnum
Purpose: Represents the different types of flowers that a product can be associated with. This enumeration ensures that the product type is restricted
to a predefined set of values, enhancing data consistency and integrity.
![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/0e7e0e6f-f4ca-4093-af0f-0a8c31ff71ce)


## Class: Delivery
Purpose: Represents the delivery details for orders placed by clients, including client information, products, delivery location, date, and method. It calculates the total value of the delivery including transport costs.

##### Attributes
DeliveryClient: A Client object representing the client who placed the order.
DeliveryProducts: A List<Product> containing the products included in the delivery.
deliveryQuantities: A List<int> representing the quantities of each product in the delivery.
deliveryLocation: A string specifying the location to which the order is to be delivered.
deliveryDate: A DateTime object representing the date the delivery is scheduled or was made.
deliveryMethod: An EnumCourier.CourierEnum value representing the method of delivery chosen for the order.

##### Properties
1) DeliveryTotalValue: A decimal property that calculates the total value of all products in the delivery by multiplying each product's price by its quantity.
Basically, it computes the subtotal of the delivery (without taking into account the cost for transportation/courier).
2) Total: A decimal property that returns the total value of the delivery, including transport costs.

##### Constructors
Parameterless Constructor: Initializes a new instance of the Delivery class with default values.
Parameterized Constructor: Initializes a new instance of the Delivery class with specified values for client, products, quantities, date, location, and delivery method.

##### Methods
GetTotalValue: Calculates the total value of the delivery by summing the product values and adding the transport cost based on the delivery method.
![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/1720c520-07ea-4686-98f7-9180e790c7ae)
DeliveryConcatenatedProducts: Creates a concatenated string representing the products and their quantities in the delivery.
![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/b7ab0f85-1dc5-46ab-b3eb-f8d9c709df13)
ReturnCostBasedOnDeliveryMethod: Determines the cost of delivery based on the chosen delivery method. It offers free delivery for orders over a certain value and provides specific costs for various courier services.
![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/a63a3b15-52a4-4e17-b166-5b75e5439364)

#### Integration with Other Classes
1) Client: The DeliveryClient attribute holds a reference to a Client object, encapsulating all the client details required for the delivery.
2) Product: The DeliveryProducts attribute contains a list of Product objects, each representing a product in the delivery.
3) EnumCourier: The deliveryMethod attribute uses the EnumCourier.CourierEnum enumeration to specify the method of delivery, ensuring that only valid delivery methods are assigned.

## EnumCourier Class
Purpose: Represents the different courier methods available for deliveries.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/ff05affc-a8c2-4553-8026-c20f53ebad4d)
This enum is used in the Delivery class to specify the delivery method, allowing for easy extension and maintenance of courier methods.
   

