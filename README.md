# Chaase.GameSparks.NET

GameSparks.NET is an API wrapper for GameSparks REST API. This package was made with the purpose of making GameSparks integrations with web application, easier for the developer. Instead of having to write your own HTTP requests, GameSparks.NET does the job for you, providing you with easy to use services, classes, and settings.
This API wrapper has support for synchronous as well as asycnhronous actions.

## Getting started

In your `Startup.cs`, you need to set the API key, the credentials, and the API secret.

```
// For test environment
GameSparksSettings.Set("apiKey", "credentials", "secret");

// For live environement
GameSparksSettings.Set("apiKey", "credentials", "secret", isLive: true);

// Or set the settings one-by-one
GameSparksSettings.SetApiKey("apiKey");
GameSparksSettings.SetCredentials("credentials");
GameSparksSettings.SetSecret("apiSecret");
GameSparksSettings.SetIsLive(true);
// Or
GameSparksSettings.SetIsLive(false);
```

This is all you need to do in order to setup the connection from GameSparks.NET to the GameSparks REST API.

## Examples

Here's a few examples to get you started. There's a service for each request section ([see here](https://docs.gamesparks.com/api-documentation/rest-apis/requests.html)). For example, there's a service for 'Admin' requests, a service for 'Player' requests, a service for 'Events' requests, etc.

### Register a new player

To register a new player, you need to first instantiate a new `GameSparksAuthenticationService`.

```
var authService = new GameSparksAuthenticationService();
```

The service has a sync/async action, that takes a `RegistrationRequest` class as parameter. Here's an example:

```
// RegistrationRequest(string displayName, string password, string userName, dynamic segments)
var regRequest = new RegistrationRequest("Christian Haase", "1337", "Chaase", null);

// Synchronous
var response = authService.RegistrationRequest(regRequest);

// Asynchronous
var response = authService.RegistrationRequestAsync(regRequest);

Console.WriteLine("Auth token: " + response.AuthToken);
Console.WriteLine("Display name: " + response.DisplayName);

// Output
// "Auth token: 5c7d4aa3-71f4-4c8b-9f01-d8712ee3cfe6"
// "Display name: Christian Haase"
```

### Authenticate a player

The `AuthenticationRequest` lies within the same service as the `RegistrationRequest`. Both can be found inside the `GameSparksAuthenticationService` service.
Here's an example of authenticating a user in GameSparks.

```

// Instantiate a new GameSparksAuthenticationService
var authService = new GameSparksAuthenticationService();

// Create the AuthenticationRequest(string userName, string password) object
var authRequest = new AuthenticationRequest("Chaase", "1234");

// Fire the request
var response = authService.AuthenticationRequest(authRequest);

Console.WriteLine("Auth token: " + response.AuthToken);
Console.WriteLine("User ID: " + response.UserId);

// Output
// "Auth token: de0e5218-d788-4f30-95ab-6495e395906c"
// "User ID: 591384bc18416804db25e546"
```

### Get player details 

To get the player details, you need to call the `AccountDetailsRequest`. This can be found in the `GameSparksPlayerService` service.

```
var playerService = new GameSparksPlayerService();

// AccountDetailsRequest(string playerId)
var response = playerService.AccountDetailsRequest(new AccountDetailsRequest("591384bc18416804db25e546"));

Console.WriteLine("Display name: " + response.DisplayName);
Console.WriteLine("User ID: " + response.UserId);

// Output
// "Display name: Chaase"
// "User ID: 591384bc18416804db25e546"
```

### Get team

The `GetTeamRequest` can be found inside the `GameSparksTeamsService` service.

```
var teamsService = new GameSparksTeamsService();

// GetTeamRequest(string ownerId, string teamId, string teamType, string playerId)
var response = teamsService.GetTeamRequest("59138d82b1b78740aff03119", "59138d88ee587cd9fd4525a9", "some-type", "591384bc18416804db25e546");
```
