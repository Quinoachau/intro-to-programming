# Our Links API

## Adding a Link

- Define the Resource
- Select the proper method (GET POST PUT DELETE)
- Define our "representation" - how we are going to pass data from the client to the server, and how the server is going to send us data.

```http
POST http://localhost:1337/links
Content-Type: application/json
Authorization: bearer 39378973973973

{
  "href": "https://allstate.com",
  "description": "Good insurance. Great Developers"
}
```

```http
GET http://localhost:1337/links/cc490c43-6ee0-4228-88e5-c6cf7843b8a1
```

Http Status Codes:

200 - 299: This worked.
    201: Created

300 - 399: need more information or redirects

400 - 499: The user agent (the client making the request) did something wrong.
    401: You need to be authenticated. We need to know who you are
    403: I know who you are and you Specifically can't do that.
    404: You asked for something we don't have.

500 - 599: We screwed up.