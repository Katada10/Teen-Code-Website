<?php
require 'PHPMailerAutoload.php';

$email = "katadafreije@yahoo.com";
$to = "teencodedev@gmail.com";
$message = "hello";
$subject = "subject";

$mail = new PHPMailer;
$mail->isSMTP(true);
$mail->Host = "gmail-smtp-in.l.google.com";
$mail->Port = 25;

$mail->addAddress($to);
$mail->Subject = $subject;
$mail->msgHTML("Message From : ".$email."<br> Message: <br>".$message);

if (!$mail->send()) {
$error = "Mailer Error: " . $mail->ErrorInfo;
echo '<p>'.$error.'</p>';
}
else {
echo '<p>Message sent!</p>';
}

?>
