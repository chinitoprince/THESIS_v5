<?php
	
	$servername = "localhost";
	$username = "root";
	$password = "";
	$dbName = "thesis";

	$user_username = $_POST["UsernamePost"];
	$user_password = $_POST["PasswordPost"];
	$user_section  = $_POST["SectionPost"];
	$user_adviser  = $_POST["AdviserPost"];
	$user_address  = $_POST["AddressPost"];
	$user_dob      = $_POST["DobPost"];
	//Make connection
	$conn = new mysqli ($servername, $username, $password, $dbName);
	//Check connection
	if (!$conn)
	{
		die ("Connection Failed.". mysqli_connect_error());
	}

	$sql = "INSERT INTO accounts (F_Name, Section, Adviser, Lrn, Address, Dob) 
	VALUES ('".$user_username."' , '".$user_section."' , '".$user_adviser."' , '".$user_password."' , '".$user_address."' , '".$user_dob."' )";
	$result= mysqli_query($conn, $sql);

	if(!result)
		{
		 echo "There was an error";
	}
	else
	{
	 echo "Everything is ok.";
	}

?>