from selenium import webdriver
from selenium.webdriver.common.keys import Keys

username = raw_input()
password = raw_input()
print(username)

driver = webdriver.Firefox()
driver.get("http://www.instagram.com")
# login_button = driver.find_elements_by_xpath("//a[text() = 'Log in']")
# login_button = driver.find_elements_by_xpath("/html[@class='js not-logged-in client-root js-focus-visible sDN5V']/body/span[@id='react-root']/section[@class='_9eogI E3X2T']/main[@class='SCxLW  o64aR']/article[@class='_4_yKc']/div[@class='rgFsT ']/div[@class='gr27e']/p[@class='izU2O']/a[@class='focus-visible']")
print("login")
print(login_button)
login_button.click()
