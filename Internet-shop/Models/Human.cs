﻿using System;

public class Human
{
    private static int _id = 0;
    private int id;
    private string name;
    private string mail;
    private string password;

    public string Name { get { return name; } set { name = value; } }

    public string Mail { get { return mail; } set { mail = value; } }

    public string Password { get { return password; } set { password = value; } }

    public int Id { get { return id; } }

	public Human(string name, string mail, string password)
    {
        _id++;
        id = _id;
        Name = name;
        Mail = mail;
        Password = password;
	}
}