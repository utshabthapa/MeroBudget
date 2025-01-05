/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        './wwwroot/**/*.html',        // HTML files in wwwroot
        './Pages/**/*.razor',         // Razor components in the Pages folder
        './Shared/**/*.razor',        // Razor components in the Shared folder
        './**/*.cshtml',              // If using Razor views
    ],
    theme: {
        extend: {},
    },
    plugins: [],
};