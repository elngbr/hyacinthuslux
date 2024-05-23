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
2) 
![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/eb9a14ac-9fef-4887-9bef-88c9c2561ecd)

3) General Exception: Thrown for a specific invalid phone number.



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

##### Integration with EnumFlower Class
The Product class integrates with the FlowerEnum class to specify the type of flower for each product. 
This integration ensures that each product can be categorized correctly, providing clear information about the type of flower it represents.

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

ReturnCostBasedOnDeliveryMethod: Determines the cost of delivery based on the chosen delivery method. It offers free delivery for orders over 
a certain value and provides specific costs for various courier services.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/a63a3b15-52a4-4e17-b166-5b75e5439364)

#### Integration with Other Classes
1) Client: The DeliveryClient attribute holds a reference to a Client object, encapsulating all the client details required for the delivery.
2) Product: The DeliveryProducts attribute contains a list of Product objects, each representing a product in the delivery.
3) EnumCourier: The deliveryMethod attribute uses the EnumCourier.CourierEnum enumeration to specify the method of delivery, ensuring that only valid delivery methods are assigned.

## EnumCourier Class
Purpose: Represents the different courier methods available for deliveries.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/ff05affc-a8c2-4553-8026-c20f53ebad4d)

This enum is used in the Delivery class to specify the delivery method, allowing for easy extension and maintenance of courier methods.

# Forms

## Class: Client_Form
The Client_Form class manages the user interface and functionalities for handling client data within the hyacinthuslux application.
This form allows users to add, update, delete, and display client information. 

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/9dd00810-05cb-4c07-850f-4770af507c5e)


##### Attributes
ConnectionString: A constant string used to connect to the SQLite database.
ErrorProvider errorProvider: An instance of ErrorProvider used to provide validation feedback to the user.
List<Client> clients: A list to hold the client data.

##### Constructor
Client_Form(): Initializes the form components and sets up the initial list of clients.
   
##### Methods
1) Client_Form_Load: Load the form, read client data from the database, and display it.
createClient: Insert a new client into the database.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/c47fb3aa-d802-42e0-aa15-31e8cb3a9e9f)

2) deleteClient: Delete a client from the database by ID.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/53e2e615-820c-470e-933c-afd1e7ae69af)

3) ReadClient: Read all clients from the database and store them in the clients list.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/86268413-eddb-46f9-9aae-ca9cfa7a8d55)

4) DisplayParticipants: Display the list of clients in the ListView control.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/ca0be431-a534-4112-b70f-b4013edfbc64)

5) updateClient: Update an existing client in the database.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/9a4dc126-6af5-4da9-951b-a13325533d70)

6) ResetForm: Reset the form fields to their default values.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/e07793c2-8074-4941-9111-56c416fee57e)


##### Event Handlers
1) bntAdd_Click: Add a new client to the list and database.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/c76cded5-1ed9-4424-980f-f5ad637c23d1)


2) btnSaveClient_Click: Save the changes made to an existing client.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/1f88fc13-5872-4623-a96d-5dd395e4b0e8)


3) btnDeleteClient_Click: Delete a selected client from the list and database.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/d3b889a6-8632-4de2-a1ba-64da7e8b9d3b)


4) lvClients_MouseDoubleClick: Load the selected client details into the form fields for editing.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/003a8d2a-e851-4481-8a0f-6ed1c2a95339)

5) tbPhoneNumber_Validating: Validate the phone number field to ensure it is not empty and has a valid length.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/eb936694-3841-496d-9f40-1b79e4aac8c3)


6) tbLastName_Validating: Validate the last name field to ensure it meets certain criteria.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/40c983c9-98c7-4cbe-8a17-5d8a7d79630c)


7) tbAddress_Validating: Validate the address field to ensure it contains a comma and is not empty or whitespace.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/bb8c2ff6-a8e0-4050-a6c9-cf20fa1e04bb)


8) tbEmail_Validating: Validate the email field to ensure it contains an "@" symbol and is not empty or whitespace.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/42e0b200-13fe-4349-aa27-327de1616e88)


9) numLoy_Validating: Validate the loyalty points field to ensure it is not greater than 99.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/a9916a69-4e24-4693-b652-6be20375ffd8)

10) Serialization and Deserialization: 
#### serializeToolStripMenuItem_Click: Serialize the client list to a binary file.
#### deserializeToolStripMenuItem_Click: Deserialize the client list from a binary file.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/dc6e71c2-86ca-4a01-a0da-c5a1aeacd6bc)


#### serializeXMLToolStripMenuItem_Click: Serialize the client list to an XML file.
#### deserializeXMLToolStripMenuItem_Click: Deserialize the client list from an XML file.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/ea4baec3-c2a1-4cee-910f-ad147bbe5996)


11) Clipboard Operations
#### btnCopy_Click: Copy the first name to the clipboard.
#### btnPaste_Click: Paste the text from the clipboard to the first name field.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/6718a6be-36b3-4141-8091-1fd8be06b006)


12) Drag and Drop Operations
#### tbPhoneNumber_MouseDown: Initiate a drag-and-drop operation with the phone number.
#### tbPhoneNumber_DragEnter: Allow a copy effect if the data format is text.
#### tbPhoneNumber_DragDrop: Handle the drop event to set the phone number text.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/22484e16-394a-46b9-9042-082922136f0d)


13) Export to TXT
ExportReportAsTxt: Export client data to a TXT file.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/ff720a8a-a28f-4cd2-9252-29ef85afca69)










