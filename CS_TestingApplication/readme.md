MSTest.TestFramework
- The Testing Suite with Object Model
	- TestClass
	- TestMethod
	- Assertion
		- CollectionAssertion
- MSTest.TestAdapter
	- The UI for Test Management
		- Run Single Test
		- RUn All Tests
		- Debug Test
		- Intelli Test
		- Test Status with Stack Trace
- Assert
	- CollectionAssert
		- Collection Reading methods for Assertion
	- ReferenceEqual Assert
- TestContext
	- DataSource is configuraed for the test
		- Read the Source file from the Test Deployment (bin) directory
		- Sql Server Data Tables
		- MS-Access sdf files /mdf files
	- DataRow
============================================================================================
MVC Testing with MS Test
1. Model Testing
	- Data Access Unit Testing
	- Business Logic testing aka Repository testing
2. Controller Testing
	- Action Methods
		- Returning Views
		- Redirection
		- ModelState
		- Exception
3. API Testing
	- HTTP Action Tests
		- Status Code
		- ModelState
		- Exception Test

Repository Design Pattern
-  Dependency Injection
	- Registration on Types
	- Injecting Types
- Mock
	- Mock object aka Fake Object
============================================================================================
Assignment 1 Day 

Write Unit Test for CategoryNewRepository for following requirements
1. If the GetCat(id) method does not return the Category Object, the throw the NotFoundException
2. Add a new method in CategoryNewRepository to create a new Category, write a test to make
sure that, the Category is created successfully.
3. If the Category Model while creation is not satisfyling the following validation rules
 - CategoryId is must
 - CategoryName is must and must be string (w/o any special character)
 - BasePrice must be positive integer
 Then the unit test must verify the error status of each of the property from Category model
4. The GetCats() method must not return an EMpty List.

============================================================================================
Unit Testing Challanges faced by developers
1. How to Test the method with multiple different data inputs?
	- Data Drive Test
		- Inline Data Values for TestMethod
			- DataRowAttribute used as [DataRow]
			- DataTestMethodAttribite class used as [DataTestMethod]
				- specify the method for inline data driven tesing method
				- Read the data for each DataRow and pass to the test Method
		- Data Driven Test from External Sources
			- File Systems
				- CSV (recommended)
				- Excel, Office Plug Comfigured to read excel file, Office 2007 adapetr 
				- Xml, Custom Data Source Provider
			- Database
				- SQL Server
				- MS Access
		- Use the DataSourceAttribute class, used as [DataSource]
			- [DataSource(DatabaseInfo / File Info)]
			- The TestContext class
				- Link the Source on the Same Unit Test Context so that all contents (Rows) from
				the data source are tested
				
2. Testing of the Customm Events written in code?
	- Create a Collection, that will store the list of events they are raised
	inside the test method. And then Assert the test based on the Collection 
	Assert or the Assert class
3. How to Test void Methods?
4. How to test method in class if its ctor injected?

==============================================================================
Assignment Day 3

Write a CategporyNewController Test, that Creates Record and if the record is successfully
created, it will redirect to the 'SuccessController' and its Action Method of 
name 'OperationSuccess'

Write a test on the CategoryNewController to test if the Edit Action method
is not returning the NULL value for the Model