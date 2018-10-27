<?php
	
	$servername = "localhost";
	$username = "root";
	$password = "";
	$dbName = "thesis";

	$user_username = $_POST["UsernamePost"];
	$user_password = $_POST["PasswordPost"];
	$user_dob = $_POST["DobPost"];
	//Make connection
	$conn = new mysqli ($servername, $username, $password, $dbName);
	//Check connection
	if (!$conn)
	{
		die ("Connection Failed.". mysqli_connect_error());
	}

	$sql = "SELECT  Lrn FROM accounts WHERE F_Name ='".$user_username."' AND Dob = '".$user_dob."' ";
	$result= mysqli_query($conn, $sql);

	if (mysqli_num_rows($result) > 0)
		//this will show data for each row
	{
		while ($row = mysqli_fetch_assoc($result))
		{
			if ($row['Lrn'] == $user_password)
			{
				if ($user_password == "102030405")
				{
						echo"Welcome Admin";
				}
				else
				{
					echo"login success";
				}	
			}
			else
			{
				echo "password incorrect";
			}

		}
		
	}
	else
		{
			echo "user not found";
		}


?>