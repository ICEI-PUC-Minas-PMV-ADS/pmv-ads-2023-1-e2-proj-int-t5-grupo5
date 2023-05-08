window.themeSwitcher = {
    toggleTheme: function (themeClass) {
        const htmlElement = document.documentElement;
        htmlElement.classList.remove("dark-theme", "light-theme");
        htmlElement.classList.add(themeClass);
    }
};