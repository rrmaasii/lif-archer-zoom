new ActionMap(zoomMap);
zoomMap.bind(mouse0, "ctrl button1",toggleU);
function toggleU(%val)
{
        if (%val)
        {
            setFov((20));
        }
        else
        {
            setFov((70));
        }
}
zoomMap.push();