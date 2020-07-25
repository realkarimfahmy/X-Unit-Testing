using System;

public class Reservation
{
	public User MadeBy { get; set; }
	public bool CanCancelledBy(User user)
	{
		return (user.IsAdmin || MadeBy == user);
	}
}
public class User
{
	public bool IsAdmin { get; set; }
}

