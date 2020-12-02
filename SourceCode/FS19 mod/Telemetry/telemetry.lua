-- @author      3dmx Modding
-- @version     v1.0.0.0
--
-- @date        20/10/20
-- @info		Realtime Script for FarmingSimulator 2019

local loopnum = 0;
Realtime = {}
addModEventListener(Realtime);

function Realtime:loadMap(name)
	self.timeHour = "%H";
	self.timeMinute = "%M";
	self.timeSecond = "%S";
end;
--2000 = 33 seconds
--.0165 per 1
function Realtime:update()
	loopnum = loopnum + 1;
	if loopnum > 5 then
		loopnum = 0;
		local vehicle = g_currentMission.vehicles[2];
		local file = io.open("Telemetryoutput.txt", "w");
		for a=1, #g_currentMission.vehicles do
				local vehicle = g_currentMission.vehicles[a];
				local vehicleName = vehicle.getFullName(vehicle); --vehicle.getName(vehicle)
				file:write(a);
				file:write("-");
				file:write(vehicleName);
				file:write(",");	
		end;

		file:write("|");


		for a=1, #g_currentMission.vehicles do
				local vehicle = g_currentMission.vehicles[a];
				local vehicleName = vehicle.getFullName(vehicle); --vehicle.getName(vehicle)
				local speed = Utils.getNoNil(vehicle.lastSpeed, 0)*3600;
				if g_gameSettings:getValue('useMiles') then speed = speed*0.621371;end;
				local direction = 0;

				local bX, bY, bZ = getWorldTranslation(vehicle.components[1].node);

				local rx,ry,rz  = localDirectionToWorld(vehicle.components[1].node, 0,0,1);
				local length = MathUtil.vector2Length(rx, rz);
				if (length ~= 0.0) then
					direction = (math.deg(math.atan2(rz / length, rx / length)) + 90.0) % 360.0; -- Rotate clockwise, so north=0, east=90, south=180, west=270.
				end

				file:write(bX);
				file:write(",");
				file:write(bY);
				file:write(",");
				file:write(bZ);
				file:write(",");
				file:write(direction);
				file:write(",");
				file:write(speed);
				file:write(",");
				file:write(a);
				file:write("-");
				file:write(vehicleName);
				file:write("|");	
		end;
		file:close();
	end;
	
end

function Realtime.prerequisitesPresent(specializations)
	return true;
end

function Realtime:mouseEvent(posX, posY, isDown, isUp, button)
end

function Realtime:draw()
end

function Realtime:keyEvent(unicode, sym, modifier, isDown)
end

function Realtime:deleteMap()
end