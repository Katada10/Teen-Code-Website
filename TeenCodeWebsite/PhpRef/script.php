<?php
require 'PHPMailerAutoload.php';


function _prev($string)
{
    echo htmlspecialchars($string, ENT_QUOTES, 'UTF-8');
}



$email = $_POST["Email"];
$name = $_POST["Name"];
$to = "teencodedev@gmail.com";
$message = $_POST["Message"];
$subject = $_POST["Subject"];

$mail = new PHPMailer;
$mail->isSMTP(true);
$mail->Host = "gmail-smtp-in.l.google.com";
$mail->Port = 25;

$mail->addAddress($to);
$mail->Subject = $subject;
$mail->msgHTML("Message From : ".$name."<br> Email: <br>".$email."<br> Subject: <br>".$subject."<br> Message: <br>".$message);


$url = "http://teencodeweb.azurewebsites.net/Home/Contact";
$errorUrl = "http://teencodeweb.azurewebsites.net/Shared/Error";


if ($mail->send()) {
    header('Location: '.$url);
}
else {
    header('Location: '.$errorUrl);
}   
?>
