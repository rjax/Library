# Library
The purpose of this repository is to demonstrate how to code a GraphQL server using HotChocolate. We start with an extremely server and add complexity one step at a time. 
## Resolvers
Resolvers are functions that fetch data for a particular field of an object in the graphql schema. The order of execution of resolvers is determined by the hierarchy of the schema. The root resolvers are evaluated first and then their children and then their childrens children and so on. Child resolvers are processed in parallel. Resolvers (with the exception of mutations) should not have side affects.

Public object properties are implicitly defined resolvers. Public functions that return a value are also resolvers.
### Step 1
1. Create a Book class
2. Create a Query class
3. Create a static list of Book instances
4. Configure the services and application configuration in the Startup file
5. Run the project and query for a book and books
### Step 2 
1. Add an Author class
2. Add Author and Author resolvers to the Query class
3. Create a static List of Author Instances
4. Run the project and query for an Author and Authors
### Step 3
* HotChocolate implicitly adds properties of classes that are exposed in the Query class as resolvers. In this step we change the Author string property of the Book class to a method that returns the Author object referenced by the AuthorId property of the Book.
* Note that HotChocolate switches the property names to camelcase in the schema.
## Step 4: Get books by author
Add a resolver to the Author class to get books by author
## Step 5: Get specific Books and Authors
Add resolvers to Query class to get books and authors by Id
Add resolvers to Query class to get books and authors by title and name
Overridden methods like Book(int id) and Book(string name) can not be used. Only one will be added to the schema. 
### Step 6: Mutation
Add Mutation class
>A mutation consists of three components, the input, the payload and the mutation itself. By convention, mutations are named as verbs, their inputs are the name with "Input" appended at the end, and they return an object that is the name with "Payload" appended.
* Mutation function: AddBook
* Input class: AddBookInput
* Output (payload) class: AddBookPayload
Modify BookList to allow adding of books
Modify AuthorsList to allow adding of Authors
### Step 7: Using ObjectType to explicitly create types




