Ryan Dunphy's Lab 16

There were many things that I learned in the ASP.NET course. The first specific thing I learned is how to interact with Bootstrap classes. While I've always known about Bootstrap, using Bootstrap classes has never been something I've interacted with personally. Specifically, learning the bootstrap syntax, how to search the bootstrap.css file for what classes I want to use, and the difference between bootstrap basic CSS how building upon that foundation works. The second thing I learned is how to use a Model, View, Controller architecture. The MVC architecure is an Architecture Framework that is extremely popular in the business world. Learning how to request Data in the View, pass that to the model, and then pass results from the Controller back to the View was extremely useful. I especially appreciated how in-depth we went on validation. I believe learning validation is one of the most essential skills for any programmer. Learning how to do that was extremely useful for me. Learning how to achieve that validation through error handling was extremely pracctical for a programmer and I appreciated that.

The application I have is not superb. There are some labs that were not done well or successfully and therefore needs some improvements in order to be a functional application. From the place the website should be however, the first thing I would like to improve is to add a shopping cart functionality to the store. Without a shopping cart, a store is not exactly useful. In addition, I would need an eCommerce payment feature in order to do transactions. Whether that was through Paypal or another module, I'd likely need to use a 3rd party plugin/API in order to achieve this in a secure manner. Finally, I would like to add a discount module for returning customers. Something where customers could sign up for a membership and then receive discounted sale prices. 

Changes made: 
In ~/Views/Shared/_Layout.cshtml:
- Created the jumbotron, then updated the Bootstrap style from bg-primary to bg-dark and added a "rounded" property to it. 

In ~/Views/Support/Support.cshtml:
- Updated Line 73: 
--- FROM: <a asp-action="Support" class="btn btn-outline-secondary p-2">Clear</a>
--- TO: <a asp-action="Support" class="btn btn-danger p-2 me-2">Clear</a>

IN ~/Views/Home/Index.cshtml:
- Updated Lines 33-34:
--- FROM: <button type="submit">Calculate Tax</button>
          <a asp-action="index">Clear</a>
--- TO: 
          <button type="submit" class="btn-success p-2 me-2 rounded">Calculate Tax</button>
          <a asp-action="index" class="btn btn-secondary p-2 me-2">Clear</a>
          
All changes completed. 
