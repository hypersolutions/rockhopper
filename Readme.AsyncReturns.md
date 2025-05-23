# Async Returns

Methods and functions that return a _Task_, _ValueTask_ or a generic form are supported by the _Returns_ method. Under the hood, it will 
work out if the return value(s) require wrapping in a _Task_ or _ValueTask_. So given the example:

```c#
public interface IUserRepository
{
    ValueTask<bool> UserExistsAsync(int id);
    Task<User?> GetUserAsync(int id);
    Task SaveAsync(User user);
}
```

If you wish to return a user for the _GetUsersAsync_ function, you would define the mock as:

```c#
var user = new User { Id = 1, Name = "Homer Simpson" };
_userRepository.Function(r => r.GetUserAsync(user.Id)).Returns(user);
```

**where** __userRepository_ is the resolved mock.

Equally for a method that returns a _Task_, you would define the mock as:

```c#
var user = new User { Id = 1, Name = "Homer Simpson" };
_userRepository.Function(r => r.SaveAsync(user)).Returns(Task.CompletedTask);
```

For a _ValueTask_ you would write:

```c#
const int userId = 1;
_userRepository.Function(r => r.UserExistsAsync(userId)).Returns(true);
```