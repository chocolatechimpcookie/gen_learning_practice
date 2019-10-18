from selenium import webdriver
from selenium.webdriver.common.keys import Keys
import time

username_input = raw_input()
password_input = raw_input()
print(username_input)
driver = webdriver.Firefox()

driver.get("http://www.instagram.com")
# driver.get("https://www.google.com")
time.sleep(3)
login_button = driver.find_element_by_xpath("//a[@href = '/accounts/login/?source=auth_switcher']")
print("login")
# print(login_button)
login_button.click()

time.sleep(1)
username_field = driver.find_element_by_xpath("//input[@name= 'username']")
username_field.send_keys(username_input)
password_field = driver.find_element_by_xpath("//input[@name= 'password']")
password_field.send_keys(password_input)

submit_login = driver.find_element_by_xpath("//button[@type='submit']")
submit_login.click()
