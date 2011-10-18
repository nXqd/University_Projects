<?php
   require(APPPATH'.libraries/REST_Controller.php');

   class Example_api extends REST_Controller {

      function location_get()
      {
         return "123";
      }

      function location_put()
      {
         // create a new location and respond with a status/errors
      }

      function location_post()
      {
         // update an existing location and respond with a status/errors
      }

      function location_delete()
      {
         // delete a location and respond with a status/errors
      }
   }
