![image](https://user-images.githubusercontent.com/56614031/178572458-7018fa4e-d408-4ae5-ab13-8e6438f87039.png)
# Table of Contents
1. [API Register](#API-Register)
2. [API Login](#API-Login)
3. [Api Refresh Token](#API-Refresh-Token)
4. [Api Scholars](#API-Scholars)
## API Register
The registration API allows the client to register users by entering their username and password
## API Login
The authentication API allows the client to authenticate with the application by entering their username and password. The server responds with the token to be able to access the resources.
## API Refresh Token
The refresh token is used to generate a new access token. Typically, if the access token has an expiration date, once it expires, the user would have to authenticate again to get an access token. With the refresh token, this step can be skipped and with a request to the API obtain a new access token that allows the user to continue accessing the application's resources.
## API Scholars
The scholar API lists all scholars available to the authenticated user
