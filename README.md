# Sitecore 9: Hello World!
Visual Studio Solution for 'Hello World' site that derives from a local installation of Sitecore 9.


<b>Tasks:</b><br />
<ol>
  <li>Installed local instance of Sitecore 9 (XP0) and necessary prerequisites</li>  
  <li>Converted sample site that comes with Sitecore 'out of the box' from WebForms to MVC</li>
  <li>Created both view and controller renderings to accommodate components with/without business logic</li>
  <li>Created Visual Studio solution with publishing profile to deploy changes to Sitecore install</li>
  <li>Implemented front-end framework (Bootstrap) to overhaul default sample site design</li>
</ol>
<br />
<b>Scaffolding:</b><br />
<ul>
  <li>
    Layout: <a href="/Shared MVC Layout.cshtml">Shared MVC Layout</a>, which contains Sitecore placeholder "main".
  </li>
  <li>
    View Rendering: <a href="/Shared MVC Rendering.cshtml">Shared MVC Rendering</a>, which contains Sitecore placeholder "centercolumn".
  </li>
  <li>
    Model: <a href="/SharedViewModel.cs">Shared View Model</a>, which declares the "Year" property (int).
    <ul>
      <li>
        Controller: <a href="/SharedController.cs">Shared Controller</a>, which defines the "Year" property and returns value in ActionResult
      </li>
      <li>
        Controller Rendering: <a href="/SharedMVCInnerRendering.cshtml">Shared MVC Inner Rendering</a>, which injects values from Sitecore fields and the returned value from the "Year" property.
      </li>
    </ul>
  </li>
  <li>
    View Rendering: <a href="/SampleMvcRendering.cshtml">Sample MVC Rendering</a>, which populates a bootstrap 'card' component with content from Sitecore fields.
  </li>
</ul>
<br />
<img src="/sc9install.PNG" alt="Sitecore 9 local installation" />
<br />
<img src="/sc9local.PNG" alt="Sitecore 9 local site" />
