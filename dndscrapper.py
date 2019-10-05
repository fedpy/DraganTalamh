from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from bs4 import BeautifulSoup

gecko = 'geckodriver'
options = webdriver.FirefoxOptions()

# uncomment for webriver visual testing
# options.add_argument('-headless')
options.add_argument('-incognito')
driver = webdriver.Firefox(executable_path=gecko, options=options)
driver.implicitly_wait(5)  # in future version explicit waits will be used
driver.get("https://roll20.net/compendium/dnd5e/Items%20List#content")

try:
    for i in range(1, 8):
        # bug if link on element below is hitting in the centre of element, offset might be a solution
        # ie like in 9th element
        driver.find_element_by_xpath("//*[@id='pagecontent']/div[3]/div[" + str(i) + "]/div[1]").click()

    pageSource = driver.page_source
    # testing printout to make sure that all elements are loaded successfully
    soup = BeautifulSoup(pageSource, 'html.parser')

finally:
    print("End")

    # leave commented to prevent navigator close
    # driver.close()
    # driver.quit()

