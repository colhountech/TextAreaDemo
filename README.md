# TextAreaDemo

Attempting to update the content of a `<TextArea>` tag on the `OnPost()` of a Razor Page is not obvious.
  
In this example, I update the content on the client side , and want to change the content on the Server Side before re-rendering

In the attached example, if I check or uncheck the CheckBox, a small piece of Javascript will update the contents of the TextArea tag.

When I submit and post back to the server, I want the content of this TextArea to be changed and re-rendered.

I attempted to update the content of the TextArea with the following code

```

public PageResult OnPost()
    {
        // this doesn't work
        Messages = $"Messages: { SimpleCheckBox.ToText() } ";
        return Page();            
     }
     
```

instead I have to do the following:

```
public PageResult OnPost()
    {
        // This works
        ModelState["Messages"].AttemptedValue = $"AttemptedValue: { SimpleCheckBox.ToText() } ";
        return Page();
     }
     
```
