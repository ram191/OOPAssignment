# OOPAssignment

## #1 Hash

Create a `Hash` class with ability to create hash string, with popular hash algorithm.

Usage example
```js
Hash.md5('secret') // 5ebe2294ecd0e0f08eab7690d2a6ee69

Hash.sha1('secret') // e5e9fa1ba31ecd1ae84f75caaa474f3a663f05f4

Hash.sha256('secret') // 2bb80d537b1da3e38bd30361aa855686bde0eacd7162fef6a25fe97bf527a25b

Hash.sha512('secret') // bd2b1aaf7ef4f09be9f52ce2d8d599674d81aa9d6a4421696dc4d93dd0619d682ce56b4d64a9ef097761ced99e0f67265b5f76085e5b0ee7ca4696b2ad6fe2b2
```

## #2 Cipher

Create `Cipher` class with ability to encrypt/decrypt a string.

Usage example
```c#
var message = Cipher.encrypt('Ini tulisan rahasia', 'p4$$w0rd')

Console.Writeline(message) // Anyone without password can't read this message

var decryptedMessage = Cipher.decrypt(message, 'p4$$w0rd')

Console.Writeline(decryptedMessage) // Ini tulisan rahasia
```

## #3 Log

Create `Log` class with ability to log text with several levels. 
The levels based on [severity levels in Syslog](https://en.wikipedia.org/wiki/Syslog#Severity_level).

The `Log` class should be able to produce output to a `app.log` file, like so
```log
[2018-04-03T12:10:36.100Z] INFO: This is an information about something.
[2018-04-03T13:21:36.201Z] ERROR: We can't divide any numbers by zero.
[2018-04-03T16:45:36.210Z] NOTICE: Someone loves your status.
[2018-04-03T23:40:36.215Z] WARNING: Insufficient funds.
[2018-04-03T23:56:36.215Z] DEBUG: This is debug message.
[2018-04-04T04:54:36.102Z] ALERT: Achtung! Achtung!
[2018-04-04T05:01:36.103Z] CRITICAL: Medic!! We've got critical damages.
[2018-04-04T05:05:36.104Z] EMERGENCY: System hung. Contact system administrator immediately!
```

It would be great if you could create filter based on level, date, and messages.
For example filter by `CRITICAL` at `2018-04-04`.

> Don't use any 3rd-party library.

## #4 Auth

Create `Auth` class with some abilities ...

Example
```c#
Auth.login({username: 'root', password: 'secret'})      // If valid, user will log in.

Auth.validate({username: 'root', password: 'secret'})   // Just verify username and password without log in.

Auth.logout()          // Log out the current logged in user.

Auth.user()            // Get information about current logged in user.

Auth.id()              // Get the User ID.

Auth.check()           // Will returns true if user already logged in.

Auth.guest()           // Will returns true if user not logged in.

Auth.lastLogin()       // Get information when the user last logged in.
```
## #5 Cart - Method Chaining

Create `Cart` class with method chaining ability. 

Usage example
```c#
Cart cart = new Cart()

// Do some chainings
cart.addItem({ item_id: 1, price: 30000, quantity: 3 })
    .addItem({ item_id: 2, price: 10000 })               // By default quantity is 1
    .addItem({ item_id: 3, price: 5000, quantity: 2 })
    .removeItem({item_id: 2})
    .addItem({ item_id: 4, price: 400, quantity: 6 })
    .addDiscount('50%')

cart.totalItems() // 3

cart.totalQuantity() // 11

cart.totalPrice() // 51200

cart.showAll() // Show all items in cart

cart.checkout() // Store data in a file
```
