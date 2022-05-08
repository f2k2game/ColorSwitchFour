
Markdown — это облегченный язык разметки, который можно использовать для добавления форматирования в текстовые документы.

## Инструкции

- Начните вводить в поле ввода, и Markdown будет отображаться в реальном времени в поле вывода!
- Кнопки в верхней части поля ввода в порядке
- Красный крест ('X'): **Очистить все Markdown**.
- Буфер обмена: **Скопируйте все Markdown** в поле ввода.
- Солнце/Луна: **Переключить темную тему**.
- Этот проект с открытым исходным кодом. Не стесняйтесь [вносить] (https://github.com/HarshKapadia2/preview-markdown) или [поднимать вопрос] (https://github.com/HarshKapadia2/preview-markdown/issues).

## Markdown Syntax

### 1. Заголовки

# Самый большой заголовок
## Второй по величине заголовок
### Третий по величине заголовок
###### Smallest Heading

---

### 2. Стилизация текста

`Inline code`

*Курсив* или _Italic text_

**Жирный текст** или __Bold text__

_**Полужирный и курсивный текст**_

или

Полужирный и курсивный текст***

**Жирный шрифт с _italic nesting_**

~~Зачеркнутый текст~~

> ПРИМЕЧАНИЕ: Текст отображается на новой строке только в том случае, если между ними есть пустая строка.

---

### 3. Lists

- Unordered list
* Unordered list

1. Ordered list
1. Ordered list

- **Написание под одним и тем же пунктом списка**

Добавление двух-трех пробелов под элементом списка для отображения абзаца под элементом списка

- **Unordered list nesting**
- Неупорядоченный вложенный элемент списка
- Unordered nested list item
- Неупорядоченный вложенный элемент списка

1. **Ordered list nesting**
1. Ordered nested list item
1. Ordered nested list item
   1. Ordered nested list item

1. **Ordered and unordered list nesting**
- Unordered nested list item
   1. Ordered nested list item
   1. Ordered nested list item
- Неупорядоченный вложенный элемент списка

> ПРИМЕЧАНИЕ: Продолжайте добавлять 3 пробела перед дефисом для каждого уровня вложенности.

---

### 4. Hyperlinks

- Внесите свой вклад в [Предварительный просмотр Markdown](https://harshkapadia2.github.io/preview-markdown/) на [GitHub](https://github.com/HarshKapadia2/preview-markdown)!
- Делайте [поднимать вопросы] (https://github.com/HarshKapadia2/preview-markdown/issues), если обнаружены какие-либо ошибки.
- [Относительная ссылка на раздел «Изображения» ниже.] (#5-изображения)
- [Относительная ссылка на логотип Preview Markdown.] (/предварительный просмотр-разметка/логотип.svg)

---

### 5. Images

![Alt text]()

![Absolute link](https://user-images.githubusercontent.com/50140864/121142987-2ba86480-c85a-11eb-82bf-16621156b329.png)

! [Относительная ссылка] (/предварительный просмотр-разметка/логотип.svg)

<img src="/preview-markdown/logo.svg" alt="Относительная ссылка на логотип" width="10%" />

---

### 6. Цитирование текста

По словам [Селены Гомес] (https://www.selenagomez.com/):

> «Доброта всегда побеждает».

Тоже

> Цитируемый текст
>
>> Вложенная кавычка

---

### 7. Код цитирования

```javascript
let message = "Thank you for using Preview Markdown!";
console.log(message);
```

---

### 8. Task Lists

- [x] Выполнить задачу
- [x] Выполнить задачу
- [x] Выполнить задачу
- [ ] Незавершенная задача

---

### 9. Escaping Markdown Syntax

*Звездочки должны быть отображены.*

Вот как это делается: *Звездочки должны быть отображены.*


Символы, которые можно экранировать с обратной косой чертой ('\') перед ними:
- \ обратная косая черта
- `   backtick
- \*   asterisk
- _   underscore
- {} фигурные скобки
- []  square brackets
- () скобки
- \#   hash mark
- \+   plus sign
- \- знак минус (дефис)
- .   dot
- !   восклицательный знак

---

### 10. Tables

Головка стола | Головка стола | Головка стола
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
можно использовать.

#### Line Break

Текст может отображаться на новой строке

добавив пустую строку между ними.

Линии также могут быть разбиты, а изображения могут быть разнесены <br /> с использованием тега '<br />'.

#### Полужирные и курсивные теги

Этот текст <b>выделен жирным шрифтом</b>, как и **этот текст**.

Этот текст <i>выделен курсивом</i>, как и *этот текст*.

#### Paragraph Tag

Тег абзаца ('<p></p>') можно использовать с атрибутом 'align' для выравнивания элементов по центру.

Eg:

<p align="center">
Этот текст выровнен по центру!
<br />
**Синтаксис Markdown** <b>не</b> будет работать в теге 'p'.
<br />
<img src="/preview-markdown/logo.svg" alt="Относительная ссылка на логотип" width="20%" />
</p>

#### Сворачиваемый раздел

<details>
<summary>Нажмите, чтобы переключить свернуть</summary>

- Hi!
- Обычный **Markdown** работает в 'здесь'.
</details>

#### Keyboard Tag

Тег клавиатуры ('<kbd></kbd>') можно использовать для представления ввода с клавиатуры.

Eg: <kbd>Ctrl</kbd> + <kbd>C</kbd>

## Resources

- [Что такое Markdown?] (https://www.markdownguide.org/getting-started)
- [Учебник по уценке](https://www.youtube.com/watch?v=HUBNt18RFbo)
- [Basic Markdown syntax](https://www.markdownguide.org/basic-syntax/)
- [Расширенный синтаксис разметки](https://www.markdownguide.org/extended-синтаксис/)
- [Распространенные ошибки уценки](https://gist.github.com/DavidAnson/006a6c2a2d9d7b21b025)

---
