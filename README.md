# YarpTest

This is just a test app to replicate what appears to be a bug in YARP.  
Maybe its not, i don't know.  
But this shows the behaviour.  


Steps to reproduce  

#
- STEP 1
- Open WebApplicationForm solution
- Run application 
- Open url http://localhost:44334/Test.aspx 
- Click the button and the postback works as expected   
(This app has no https as it represents an app with no certificate, behind a load balancer with the certificate, this however has no influance in the behaviour)

#

- STEP 2
- Open WebApplicationCore solution
- Run application 
- Open url https://localhost:44330/
- There you will see a link to "/Test.aspx"
- This link will use YARP and call the WebApplicationForm app
- Since its a GET, it works correctly
- Clik the button to postback the form
- The application hangs and returns 504 after a while

#
- STEP 3
- Comment out the access to "context.Request.Form" in the middleware
-  (Line 19 in UrlRewriteMiddleware.cs)
- Try STEP 2 again
- This time the postbak will work 

