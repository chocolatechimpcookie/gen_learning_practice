from selenium import webdriver
from selenium.webdriver.common.keys import Keys
import time
import unittest

        # testrencemcexam


class InstagramSearch(unittest.TestCase):

    def test(self):
        # user data input
        username_input = raw_input()
        password_input = raw_input()
        profilename= raw_input()
        print(username_input)
        driver = webdriver.Firefox()
        # unit = unittest.TestCase

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
        # notification_button_not_now = driver.find_element_by_xpath("//button[text()='Not Now']")
        time.sleep(3)
        try:
            notification_button_not_now = driver.find_element_by_xpath("//button[text()='Not Now']")
            notification_button_not_now.click()
        except:
            print("Notification isn't there ")


        search_bar_unclicked = driver.find_element_by_xpath("//span[text()='Search']")
        search_bar_unclicked.click()
        time.sleep(3)
        search_bar_unclicked = driver.find_element_by_xpath("//input[@placeholder='Search']")
        search_bar_unclicked.send_keys("Pizza")
        time.sleep(3)
        hashtagpizza = driver.find_element_by_xpath("//a[@href='/explore/tags/pizza/']")
        hashtagpizza.click()
        time.sleep(3)
        self.assertEqual(driver.current_url,"https://www.instagram.com/explore/tags/pizza/")


        # profile_button = driver.find_element_by_xpath("//svg[@aria-label='Profile']")
        # profilelocator = "//a[@href='/"+profilename+"/']"
        # profile_button = driver.find_element_by_xpath(profilelocator)
        # profile_button.click()
        # time.sleep(3)
        # edit_profile = driver.find_element_by_xpath("//button[text()='Edit Profile']")
        # driver.assertEqual("Edit Profile", edit_profile.getAttribute("innerText"))
        # driver.assertEqual("Edit Profile", edit_profile.getAttribute("textContent"))
        # print(edit_profile.get_attribute("textContent"))
        # assert "Edit Profile" in edit_profile.get_attribute("textContent")

        # self.assertEqual("Edit Profile", edit_profile.get_attribute("textContent"))

if __name__ == '__main__' :
    unittest.main()
