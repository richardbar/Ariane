/**
 * Ariane
 * Copyright (C) 2020  Richard Bariampa
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 *
 * Maintainers:
 * Richard Bariampa (richardbar) <richard1996ba@gmail.com>, <richard2003ba@outlook.com>
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ariane
{
    class TripleData
    {
        public int from, to;
        public string type;
    }

    class Selections
    {
        public List<TripleData> selections { get; } = new List<TripleData>();

    }
}
