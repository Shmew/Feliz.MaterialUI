Sign-in page
============

A simple sign-in page. It also demonstrates strongly typed (domain driven) form validation. Note that it’s not meant to be a perfect example of domain modelling or error handling; it’s just enough for this example, and hopefully sufficient to whet your appetite.

There are many UX concerns when it comes to form validation. In this form, it’s kept fairly simple and modern: The submit button is always enabled, and validation is enabled on each field once it loses focus, and for the whole form if you try to submit invalid data.

Some things you can try (from a fresh reload):

* Enter an invalid email and tab to the next field. Tab back and enter a valid email to see the error disappear.
* Enter an invalid email (or nothing at all) and press Enter. Complete the form to see the errors disappear.

```sample
SignIn.fs
```
