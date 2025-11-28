#!/bin/bash
sudo apt-get update
sudo apt-get install -y apache2 php libapache2-mod-php php-mysql

# Вмикаємо Apache
sudo systemctl enable apache2
sudo systemctl start apache2

# Завантажуємо тестовий додаток (той самий, що в оригіналі)
if [ ! -f /var/www/html/bootcamp-app.tar.gz ]; then
    cd /var/www/html
    sudo rm index.html
    sudo wget http://fgcom.org.uk/wp-content/uploads/2020/08/bootcamp-app.tar
    sudo tar xvf bootcamp-app.tar
    sudo chown www-data:www-data /var/www/html/rds.conf.php
fi