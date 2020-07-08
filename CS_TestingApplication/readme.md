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

