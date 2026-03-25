# PruebaMaui - Aplicación .NET MAUI

Proyecto de demostración desarrollado con **.NET MAUI** que permite compilar y ejecutar la aplicación en **iOS** utilizando **únicamente Windows**, sin necesidad de un Mac físico.

## 🚀 Compilación para iOS (sin Mac)

Esta solución utiliza **GitHub Actions** para compilar la app en la nube y generar el archivo `.ipa`, que luego se instala en el iPhone mediante **Sideloadly**.

### Características principales

- Compilación 100% en la nube con GitHub Actions (`macos-26`)
- No requiere Mac físico ni Xcode local
- Firma e instalación con Sideloadly (Apple ID gratuito)
- Compatible con .NET 10 y iOS 18+
- Ideal para desarrollo y pruebas internas

### Cómo compilar para iOS

1. Realiza cambios y haz **push** a la rama `main`
2. Ve a la pestaña **Actions** → selecciona el workflow **"Build iOS .ipa (para Sideloadly)"**
3. Haz clic en **Run workflow**
4. Al finalizar, descarga el artefacto `PruebaMaui-IPA`
5. Instala el `.ipa` en tu iPhone usando [Sideloadly](https://sideloadly.io)

> **Nota:** Con Apple ID gratuito la aplicación expira cada 7 días. Solo debes recompilar e instalar nuevamente.

### Estructura del repositorio
