﻿using System.Numerics;
BigInteger a = BigInteger.Parse("749832174983217498231749827349873214987321498732149873982173498732198749832165237165732165987326598732659872316487632198746987321648732164872164871326498732658732153214641324321478321649832174983217498174981244781326487162498124981498374198312469832149816198649812747498321749832174982317498273498732149873214987321498739821734987321987498321652371657321659873265987326598723164876321987469873216487321648721648713264987326587321532146413243214783216498321749832174981749812447813264871624981249814983741983124698321498161986498127474983217498321749823174982734987321498732149873214987398217349873219874983216523716573216598732659873265987231648763219874698732164873216487216487132649873265873215321464132432147832164983217498321749817498124478132648716249812498149837419831246983214981619864981274749832174983217498231749827349873214987321498732149873982173498732198749832165237165732165987326598732659872316487632198746987321648732164872164871326498732658732153214641324321478321649832174983217498174981244781326487162498124981498374198312469832149816198649812747498321749832174982317498273498732149873214987321498739821734987321987498321652371657321659873265987326598723164876321987469873216487321648721648713264987326587321532146413243214783216498321749832174981749812447813264871624981249814983741983124698321498161986498127474983217498321749823174982734987321498732149873214987398217349873219874983216523716573216598732659873265987231648763219874698732164873216487216487132649873265873215321464132432147832164983217498321749817498124478132648716249812498149837419831246983214981619864981274749832174983217498231749827349873214987321498732149873982173498732198749832165237165732165987326598732659872316487632198746987321648732164872164871326498732658732153214641324321478321649832174983217498174981244781326487162498124981498374198312469832149816198649812747498321749832174982317498273498732149873214987321498739821734987321987498321652371657321659873265987326598723164876321987469873216487321648721648713264987326587321532146413243214783216498321749832174981749812447813264871624981249814983741983124698321498161986498127474983217498321749823174982734987321498732149873214987398217349873219874983216523716573216598732659873265987231648763219874698732164873216487216487132649873265873215321464132432147832164983217498321749817498124478132648716249812498149837419831246983214981619864981274749832174983217498231749827349873214987321498732149873982173498732198749832165237165732165987326598732659872316487632198746987321648732164872164871326498732658732153214641324321478321649832174983217498174981244781326487162498124981498374198312469832149816198649812747498321749832174982317498273498732149873214987321498739821734987321987498321652371657321659873265987326598723164876321987469873216487321648721648713264987326587321532146413243214783216498321749832174981749812447813264871624981249814983741983124698321498161986498127474983217498321749823174982734987321498732149873214987398217349873219874983216523716573216598732659873265987231648763219874698732164873216487216487132649873265873215321464132432147832164983217498321749817498124478132648716249812498149837419831246983214981619864981274749832174983217498231749827349873214987321498732149873982173498732198749832165237165732165987326598732659872316487632198746987321648732164872164871326498732658732153214641324321478321649832174983217498174981244781326487162498124981498374198312469832149816198649812747498321749832174982317498273498732149873214987321498739821734987321987498321652371657321659873265987326598723164876321987469873216487321648721648713264987326587321532146413243214783216498321749832174981749812447813264871624981249814983741983124698321498161986498127474983217498321749823174982734987321498732149873214987398217349873219874983216523716573216598732659873265987231648763219874698732164873216487216487132649873265873215321464132432147832164983217498321749817498124478132648716249812498149837419831246983214981619864981274749832174983217498231749827349873214987321498732149873982173498732198749832165237165732165987326598732659872316487632198746987321648732164872164871326498732658732153214641324321478321649832174983217498174981244781326487162498124981498374198312469832149816198649812747498321749832174982317498273498732149873214987321498739821734987321987498321652371657321659873265987326598723164876321987469873216487321648721648713264987326587321532146413243214783216498321749832174981749812447813264871624981249814983741983124698321498161986498127474983217498321749823174982734987321498732149873214987398217349873219874983216523716573216598732659873265987231648763219874698732164873216487216487132649873265873215321464132432147832164983217498321749817498124478132648716249812498149837419831246983214981619864981274749832174983217498231749827349873214987321498732149873982173498732198749832165237165732165987326598732659872316487632198746987321648732164872164871326498732658732153214641324321478321649832174983217498174981244781326487162498124981498374198312469832149816198649812747498321749832174982317498273498732149873214987321498739821734987321987498321652371657321659873265987326598723164876321987469873216487321648721648713264987326587321532146413243214783216498321749832174981749812447813264871624981249814983741983124698321498161986498127474983217498321749823174982734987321498732149873214987398217349873219874983216523716573216598732659873265987231648763219874698732164873216487216487132649873265873215321464132432147832164983217498321749817498124478132648716249812498149837419831246983214981619864981274312");
BigInteger b = BigInteger.Parse("749832174983217498231749827349873214987321498732149873982173498732198749832165237165732165987326598732659872316487632198746987321648732164872164871326498732658732153214641324321478321649832174983217498174981244781326487162498124981498374198312469832149816198649812747498321749832174982317498273498732149873214987321498739821734987321987498321652371657321659873265987326598723164876321987469873216487321648721648713264987326587321532146413243214783216498321749832174981749812447813264871624981249814983741983124698321498161986498127474983217498321749823174982734987321498732149873214987398217349873219874983216523716573216598732659873265987231648763219874698732164873216487216487132649873265873215321464132432147832164983217498321749817498124478132648716249812498149837419831246983214981619864981274749832174983217498231749827349873214987321498732149873982173498732198749832165237165732165987326598732659872316487632198746987321648732164872164871326498732658732153214641324321478321649832174983217498174981244781326487162498124981498374198312469832149816198649812747498321749832174982317498273498732149873214987321498739821734987321987498321652371657321659873265987326598723164876321987469873216487321648721648713264987326587321532146413243214783216498321749832174981749812447813264871624981249814983741983124698321498161986498127474983217498321749823174982734987321498732149873214987398217349873219874983216523716573216598732659873265987231648763219874698732164873216487216487132649873265873215321464132432147832164983217498321749817498124478132648716249812498149837419831246983214981619864981274749832174983217498231749827349873214987321498732149873982173498732198749832165237165732165987326598732659872316487632198746987321648732164872164871326498732658732153214641324321478321649832174983217498174981244781326487162498124981498374198312469832149816198649812747498321749832174982317498273498732149873214987321498739821734987321987498321652371657321659873265987326598723164876321987469873216487321648721648713264987326587321532146413243214783216498321749832174981749812447813264871624981249814983741983124698321498161986498127474983217498321749823174982734987321498732149873214987398217349873219874983216523716573216598732659873265987231648763219874698732164873216487216487132649873265873215321464132432147832164983217498321749817498124478132648716249812498149837419831246983214981619864981274749832174983217498231749827349873214987321498732149873982173498732198749832165237165732165987326598732659872316487632198746987321648732164872164871326498732658732153214641324321478321649832174983217498174981244781326487162498124981498374198312469832149816198649812747498321749832174982317498273498732149873214987321498739821734987321987498321652371657321659873265987326598723164876321987469873216487321648721648713264987326587321532146413243214783216498321749832174981749812447813264871624981249814983741983124698321498161986498127474983217498321749823174982734987321498732149873214987398217349873219874983216523716573216598732659873265987231648763219874698732164873216487216487132649873265873215321464132432147832164983217498321749817498124478132648716249812498149837419831246983214981619864981274749832174983217498231749827349873214987321498732149873982173498732198749832165237165732165987326598732659872316487632198746987321648732164872164871326498732658732153214641324321478321649832174983217498174981244781326487162498124981498374198312469832149816198649812747498321749832174982317498273498732149873214987321498739821734987321987498321652371657321659873265987326598723164876321987469873216487321648721648713264987326587321532146413243214783216498321749832174981749812447813264871624981249814983741983124698321498161986498127474983217498321749823174982734987321498732149873214987398217349873219874983216523716573216598732659873265987231648763219874698732164873216487216487132649873265873215321464132432147832164983217498321749817498124478132648716249812498149837419831246983214981619864981274749832174983217498231749827349873214987321498732149873982173498732198749832165237165732165987326598732659872316487632198746987321648732164872164871326498732658732153214641324321478321649832174983217498174981244781326487162498124981498374198312469832149816198649812747498321749832174982317498273498732149873214987321498739821734987321987498321652371657321659873265987326598723164876321987469873216487321648721648713264987326587321532146413243214783216498321749832174981749812447813264871624981249814983741983124698321498161986498127474983217498321749823174982734987321498732149873214987398217349873219874983216523716573216598732659873265987231648763219874698732164873216487216487132649873265873215321464132432147832164983217498321749817498124478132648716249812498149837419831246983214981619864981274749832174983217498231749827349873214987321498732149873982173498732198749832165237165732165987326598732659872316487632198746987321648732164872164871326498732658732153214641324321478321649832174983217498174981244781326487162498124981498374198312469832149816198649812747498321749832174982317498273498732149873214987321498739821734987321987498321652371657321659873265987326598723164876321987469873216487321648721648713264987326587321532146413243214783216498321749832174981749812447813264871624981249814983741983124698321498161986498127474983217498321749823174982734987321498732149873214987398217349873219874983216523716573216598732659873265987231648763219874698732164873216487216487132649873265873215321464132432147832164983217498321749817498124478132648716249812498149837419831246983214981619864981274312");
BigInteger c;
BigInteger d;
c = a + b;
d = a * b;
Console.WriteLine($"Сумма: {c}\r\n\r\n\r\n\r\n\r\nПроизведение: {d}");