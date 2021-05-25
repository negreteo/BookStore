# Creating an Application from Scratch using .NET Core and Angular (2020)

[Part 1 - Creating the initial structure](https://henriquesd.medium.com/creating-an-application-from-scratch-using-net-core-and-angular-part-1-d1c66733c57d)

[Part 2 - Implementing the Models and creating the Database with EF Core](https://henriquesd.medium.com/creating-an-application-from-scratch-using-net-core-and-angular-part-2-95e67eebadde)

[Part 3 - Implementing the Service classes and the Repository Pattern](https://henriquesd.medium.com/creating-an-application-from-scratch-using-net-core-and-angular-part-3-e3c42cd9cc01)

[Part 4 - Implementing the API Layer](https://henriquesd.medium.com/creating-an-application-from-scratch-using-net-core-and-angular-part-4-8718e3f529aa)

[Part 5 - Implementing the SPA (Angular Project)](https://henriquesd.medium.com/creating-an-application-from-scratch-using-net-core-and-angular-part-5-ab1ac4cd5609)

[Part 6 - Implementing Unit Tests for the Domain Layer](https://henriquesd.medium.com/creating-an-application-from-scratch-using-net-core-and-angular-part-6-76daa358db41)

[Part 7 - Implementing Unit Tests for the API Layer](https://henriquesd.medium.com/creating-an-application-from-scratch-using-net-core-and-angular-part-7-8b7f77772b36)

[Part 8 - Implementing Unit Tests for the Infrastructure Layer](https://henriquesd.medium.com/creating-an-application-from-scratch-using-net-core-and-angular-part-8-85018dc84429)<br><br>

# HTTP Verbs

HTTP defines a set of request methods to indicate the desired action to be performed for a given resource. Although they can also be nouns, these request methods are sometimes referred to as HTTP verbs.

The basics verbs are:

**GET** — which request a representation of a specific resource. It is used only to return data.\
**POST** — which is used to submit an entity to a specific resource. We generally use POST to create a new resource.\
**PUT** — which is used to replace all the properties of a resource. We generally use PUT to update a resource.\
**PATCH** — which is used to apply partial modifications.\
**DELETE** — which is used to delete a resource.<br><br>

# API Status Code

https://localhost:5001/swagger/index.html

The status code is returned in the result of the API. When the client makes a request to an API, it will return a status code from the server after the request is made. The mains status code are:

**200 — Ok**: This status means that the request was successful.\
**201 — Created**: This status means that the request has succeeded and a new resource has been created as a result. This is usually returned after a POST request.\
**204 — No Content**: We can return this status when we do not want to return anything.\
**400 — BadRequest**: This is a generic status for error. It means that the server could not understand the request due to invalid syntax.\
**401 — Unauthorized**: This status means that the client is not authenticated, and he should authenticate to do the request.\
**403 — Forbidden**: This status means that the client is authenticated but he does not have permission to do what he is trying to do. Unlike 401, the client’s identity is known to the server.\
**404 — Not found**: This status means that the server could not find the requested resource.\
**500 — Internal Server Error**: This is a generic answer from REST API, it means that the server has encountered a situation it doesn’t know how to handle.\
**503 — Service Unavailable**: This status means that the server is not ready to handle the request.
