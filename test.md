
Markdown — это облегченный язык разметки, который можно использовать для добавления форматирования к документам с открытым текстом.

## Instructions

- Начните вводить текст в поле ввода, и Markdown будет отображаться в поле вывода!
- Кнопки сверху поля ввода по порядку
- Красный крест ('X'): **Очистить все уценки**.
- Буфер обмена: ** Скопируйте все Markdown ** в поле ввода.
- Солнце/луна: **переключить темную тему**.
- Этот проект с открытым исходным кодом. Не стесняйтесь [внести свой вклад](https://github.com/HarshKapadia2/preview-markdown) или [поднять вопрос](https://github.com/HarshKapadia2/preview-markdown/issues).

## Markdown Syntax

### 1. Заголовки

# Самый большой заголовок
## Второй по величине заголовок
### Третий по величине заголовок
###### Smallest Heading

---

### 2. Стилизация текста

`Inline code`

*Курсив* или _Курсив_

**Жирный текст** или __Жирный текст__

_**Жирный и курсивный текст**_

или

***Жирный шрифт и курсив***

**Жирный шрифт с _курсивом_**

~~Зачеркнутый текст~~

> ПРИМЕЧАНИЕ. Текст отображается на новой строке, только если между ними есть пустая строка.

---

### 3. Lists

- Unordered list
* Unordered list

1. Ordered list
1. Ordered list

- **Запись под одним и тем же пунктом списка**

Добавьте от двух до трех пробелов под элементом списка, чтобы отобразить абзац под элементом списка.

- **Unordered list nesting**
- Unordered nested list item
- Unordered nested list item
   - Unordered nested list item

1. **Ordered list nesting**
1. Ordered nested list item
1. Ordered nested list item
   1. Ordered nested list item

1. **Ordered and unordered list nesting**
- Unordered nested list item
   1. Ordered nested list item
   1. Ordered nested list item
- Unordered nested list item

> ПРИМЕЧАНИЕ. Продолжайте добавлять 3 пробела перед дефисом для каждого уровня вложенности.

---

### 4. Hyperlinks

- Внесите свой вклад в [Preview Markdown](https://harshkapadia2.github.io/preview-markdown/) на [GitHub](https://github.com/HarshKapadia2/preview-markdown)!
- Делайте [поднимите вопросы](https://github.com/HarshKapadia2/preview-markdown/issues), если обнаружены какие-либо ошибки.
- [Относительная ссылка на раздел `Изображения` ниже.](#5-images)
- [Относительная ссылка на логотип Preview Markdown.](/preview-markdown/logo.svg)

---

### 5. Images

![Alt text]()

![Absolute link](https://user-images.githubusercontent.com/50140864/121142987-2ba86480-c85a-11eb-82bf-16621156b329.png)

![Relative link](/preview-markdown/logo.svg)

<img src="/preview-markdown/logo.svg" alt="Относительная ссылка на логотип" width="10%" />

---

### 6. Quoting Text

По словам [Селены Гомес] (https://www.selenagomez.com/):

> «Доброта всегда побеждает».

Также,

>Цитируемый текст
>
>> Вложенная цитата

---

### 7. Код цитирования

```javascript
let message = "Thank you for using Preview Markdown!";
console.log(message);
```

---

### 8. Task Lists

- [x] Complete task
- [x] Complete task
- [x] Complete task
- [ ] Неполное задание

---

### 9. Экранирование синтаксиса Markdown

*Звездочки должны отображаться.*

Вот как это делается: *Должны быть отрисованы звездочки.*


Символы, которые можно экранировать с помощью обратной косой черты (`\`) перед ними:
- \ обратная косая черта
- `   backtick
- \*   asterisk
- _   underscore
- {}  фигурные скобки
- []  square brackets
- ()  круглые скобки
- \#   hash mark
- \+   plus sign
- \-   minus sign (hyphen)
- .   dot
- ! восклицательный знак

---

### 10. Tables

Глава стола | Глава стола | Голова стола
---------- | ---------- | ----------
foo | bar | baz
| bar | baz
foo | | baz
foo | bar
фу
#### Table Alignment

Left Aligned | Center Aligned | Right Aligned
:----------- | :------------: | ------------:
foo | bar | baz
| bar | baz
foo | | baz
foo | bar
фу

---

### 11. Misc

#### Horizontal Rule

---
или
***
или
<hr />
может быть использован.

#### Line Break

Текст может отображаться на новой строке

добавив между ними пустую строку.

Линии также можно разбивать, а изображения размещать на расстоянии<br />с помощью тега `<br />`.

#### Теги, выделенные полужирным шрифтом и курсивом

Этот текст выделен <b>полужирным шрифтом</b>, как и **этот текст**.

Этот текст выделен <i>курсивом</i>, как и *этот текст*.

#### Paragraph Tag

Тег абзаца (`<p></p>`) можно использовать с атрибутом align для выравнивания элементов по центру.

Eg:

<p align="center">
Этот текст выровнен по центру!
<br />
**Синтаксис Markdown** <b>не</b> работает внутри тега 'p'.
<br />
<img src="/preview-markdown/logo.svg" alt="Относительная ссылка на логотип" width="20%" />
</p>

#### Сворачиваемый раздел

<details>
<summary>Нажмите, чтобы свернуть</summary>

- Hi!
- Обычный **Markdown** работает здесь.
</details>

#### Keyboard Tag

Тег клавиатуры (`<kbd></kbd>`) может использоваться для представления ввода с клавиатуры.

Eg: <kbd>Ctrl</kbd> + <kbd>C</kbd>

## Resources

- [Что такое Markdown?](https://www.markdownguide.org/getting-started)
- [Учебник по уценке](https://www.youtube.com/watch?v=HUBNt18RFbo)
- [Basic Markdown syntax](https://www.markdownguide.org/basic-syntax/)
- [Расширенный синтаксис Markdown] (https://www.markdownguide.org/extended-syntax/)
- [Распространенные ошибки Markdown] (https://gist.github.com/DavidAnson/006a6c2a2d9d7b21b025)

---
