<?php
   class User_model extends CI_Model {

      function __construct() {
         parent::__construct();
      }

      function insert($user,$pass,$email='',$auto_login = true) {

         // check if there is already a username
         $this->db->where('username', $user);
         $q = $this->db->get('user');

         if ($q->num_rows() > 0) return false;

         $md5_pass = md5($pass);
         if (!$this->db->insert('user', array('username' => $user, 'password' => $md5_pass, 'email' => $email)))
         return false;

         $user_id = $this->db->insert_id();

         //Automatically login to created account
         check_autoLogin($auto_login);

         //Login was successful
         return true;
      }

      function login($user,$pass, $auto_login = true) {
         if ($user == '' || $pass == '') return false;

         // check in the user table
         $md5_pass = md5($pass);

         $this->db->where(array('username' => $user, 'password' => $md5_pass));
         $q = $this->db->get('user');

         if ($q->num_rows() > 0) {
            //Automatically login to created account
            check_autoLogin($auto_login);

            // login successfully
            return true;
         }

         return false;
      }

      function logout() {
         $this->session->sess_destroy();
      }

      private function check_autoLogin($auto_login) {
         if($auto_login) {
            //Destroy old session
            $this->session->sess_destroy();

            //Create a fresh, brand new session
            $this->session->sess_create();

            //Set session data
            $this->session->set_userdata(array('id' => $user_id,'username' => $user));

            //Set logged_in to true
            $this->session->set_userdata(array('logged_in' => true));
         }
      }

   }
