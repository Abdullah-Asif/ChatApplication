﻿namespace ChitChat.Identity.Documents;

[BsonCollection("Users")]
public class User : Document
{
    public string Name { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
