from selenium import webdriver
from selenium.webdriver.common.keys import Keys
import time

# user data input
username_input = raw_input()
password_input = raw_input()
print(username_input)
driver = webdriver.Firefox()

# Navigate
driver.get("http://www.instagram.com")
time.sleep(3)
login_button = driver.find_element_by_xpath("//a[@href = '/accounts/login/?source=auth_switcher']")
login_button.click()

# Login
time.sleep(1)
username_field = driver.find_element_by_xpath("//input[@name= 'username']")
username_field.send_keys(username_input)
password_field = driver.find_element_by_xpath("//input[@name= 'password']")
password_field.send_keys(password_input)
submit_login = driver.find_element_by_xpath("//button[@type='submit']")
submit_login.click()


# If the notification button comes up -> click not Now
# its not picking up the notification buttons 
time.sleep(1)
notification_button_not_now = driver.find_element_by_xpath("//button[text()='Not Now']")

# try:
    # notification_button_not_now = driver.find_element_by_xpath("//button[text()='Not Now']")
    # notification_button_not_now.click()
# except:
    # print("Notification isn't there ")

# check loggedin
# story_element = driver.find_element_by_xpath("//div[text()='Stories']")
# driver.assertEqual()
# print(story_element);
