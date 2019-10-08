# ============================================================================
#
# Author: jawakow
# Date: 5 Oct 2019
# Description: Page Source Parser for the Dragan Talamh Project
#
# ============================================================================

import selenium.common.exceptions as exceptions
from selenium import webdriver as web_driver
from bs4 import BeautifulSoup as web_parser


class WebScrapper:
    """

    """

    def __init__(self):
        self.target_url = "https://roll20.net/compendium/dnd5e/Items%20List#content"

    def create_session(self):
        """

        :return:
        """

        try:
            options = web_driver.FirefoxOptions()
            options.add_argument("-incognito")
            options.add_argument("--ignore-certificate-errors")

            session = web_driver.Firefox(options=options)

            return session

        except exceptions.WebDriverException as wde:
            print("Session Error: {}".format(wde))
            return False

    def get_page_source(self):
        """

        :return:
        """

        try:
            session = self.create_session()
            session.implicitly_wait(5)
            session.get(self.target_url)

            # TODO: There is a bug if a link on the element is overlapping its centre ie like in 9th element
            for i in range(1, 8):
                session.find_element_by_xpath(
                    "//*[@id='pagecontent']/div[3]/div[" + str(i) + "]/div[1]"
                ).click()

            page_source = session.page_source
            return page_source

        except exceptions.ElementClickInterceptedException as ecie:
            print("Source Code Error: {}".format(ecie))
            return False

        except exceptions.ElementNotVisibleException as enve:
            print("Source Code Error: {}".format(enve))
            return False

    def parse_page_source(self):
        """

        :return:
        """

        html = web_parser(self.get_page_source(), "html.parser")
        print(html.h1)


if __name__ == "__main__":
    WebScrapper().parse_page_source()
