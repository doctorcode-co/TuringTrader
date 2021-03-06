﻿//==============================================================================
// Project:     TuringTrader: SimulatorEngine.Tests
// Name:        DataSourceFred
// Description: unit test for FRED data source
// History:     2019v15, FUB, created
//------------------------------------------------------------------------------
// Copyright:   (c) 2011-2019, Bertram Solutions LLC
//              https://www.bertram.solutions
// License:     This file is part of TuringTrader, an open-source backtesting
//              engine/ market simulator.
//              TuringTrader is free software: you can redistribute it and/or 
//              modify it under the terms of the GNU Affero General Public 
//              License as published by the Free Software Foundation, either 
//              version 3 of the License, or (at your option) any later version.
//              TuringTrader is distributed in the hope that it will be useful,
//              but WITHOUT ANY WARRANTY; without even the implied warranty of
//              MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//              GNU Affero General Public License for more details.
//              You should have received a copy of the GNU Affero General Public
//              License along with TuringTrader. If not, see 
//              https://www.gnu.org/licenses/agpl-3.0.
//==============================================================================

#region libraries
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuringTrader.Simulator;
#endregion

namespace SimulatorEngine.Tests
{
    [TestClass]
    public class DataSourceFred
    {
        [TestMethod]
        public void Test_DataRetrieval()
        {
            var ds = DataSource.New("fred:GDPC1");

            ds.LoadData(DateTime.Parse("09/30/2018"), DateTime.Parse("01/03/2019"));

            Assert.IsTrue(ds.Info[TuringTrader.Simulator.DataSourceParam.name].ToLower().Contains("real gross domestic product"));
            Assert.IsTrue(((DateTime)ds.FirstTime).Date == DateTime.Parse("01/01/1947"));
            //Assert.IsTrue(((DateTime)ds.LastTime).Date == DateTime.Parse("01/11/2019"));
            Assert.IsTrue(ds.Data.Count() == 64);
            Assert.IsTrue(Math.Abs(ds.Data.First().Open - 18765.256) < 1e-2);
            Assert.IsTrue(Math.Abs(ds.Data.Last().Close - 18912.326) < 1e-2);
        }
    }
}

//==============================================================================
// end of file