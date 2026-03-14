

class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
}


class UserBuilder
{
    private User _user = new User();

    public UserBuilder SetName(string name)
    {
        _user.Name = name;
        return this;
    }

    public UserBuilder SetAge(int age)
    {
        _user.Age = age;
        return this;
    }

    public UserBuilder SetAddress(string address)
    {
        _user.Address = address;
        return this;
    }

    public User Build()
    {
        return _user;
    }
}

