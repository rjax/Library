# Library
The purpose of this repository is to demonstrate how to code a GraphQL server using HotChocolate. We start with an extremely server and add complexity one step at a time. 
## Step 1
1. Create a Book class
2. Create a Query class
3. Create a static list of Book instances
4. Configure the services and application configuration in the Startup file
5. Run the project and query for a book and books
## Step 2 
1. Add an Author class
2. Add Author and Author resolvers to the Query class
3. Create a static List of Author Instances
4. Run the project and query for an Author and Authors
## Step 3
* HotChocolate implicitly adds properties of classes that are exposed in the Query class as resolvers. In this step we change the Author string property of the Book class to a method that returns the Author object referenced by the AuthorId property of the Book.
* Note that HotChocolate switches the property names to camelcase.

