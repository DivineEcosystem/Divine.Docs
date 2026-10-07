# <a id="Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle"></a> Class CSVCMsg\_CrosshairAngle

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_CrosshairAngle : IMessage<CSVCMsg_CrosshairAngle>, IEquatable<CSVCMsg_CrosshairAngle>, IDeepCloneable<CSVCMsg_CrosshairAngle>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_CrosshairAngle](Divine.Protobufs.Dota2.CSVCMsg\_CrosshairAngle.md)

#### Implements

IMessage<CSVCMsg\_CrosshairAngle\>, 
[IEquatable<CSVCMsg\_CrosshairAngle\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_CrosshairAngle\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CSVCMsg\_CrosshairAngle\>\(CSVCMsg\_CrosshairAngle, params CSVCMsg\_CrosshairAngle\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle__ctor"></a> CSVCMsg\_CrosshairAngle\(\)

```csharp
public CSVCMsg_CrosshairAngle()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle__ctor_Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle_"></a> CSVCMsg\_CrosshairAngle\(CSVCMsg\_CrosshairAngle\)

```csharp
public CSVCMsg_CrosshairAngle(CSVCMsg_CrosshairAngle other)
```

#### Parameters

`other` [CSVCMsg\_CrosshairAngle](Divine.Protobufs.Dota2.CSVCMsg\_CrosshairAngle.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle_AngleFieldNumber"></a> AngleFieldNumber

```csharp
public const int AngleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle_Angle"></a> Angle

```csharp
public CMsgQAngle Angle { get; set; }
```

#### Property Value

 [CMsgQAngle](Divine.Protobufs.Dota2.CMsgQAngle.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_CrosshairAngle> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_CrosshairAngle](Divine.Protobufs.Dota2.CSVCMsg\_CrosshairAngle.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_CrosshairAngle Clone()
```

#### Returns

 [CSVCMsg\_CrosshairAngle](Divine.Protobufs.Dota2.CSVCMsg\_CrosshairAngle.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle_Equals_Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle_"></a> Equals\(CSVCMsg\_CrosshairAngle\)

```csharp
public bool Equals(CSVCMsg_CrosshairAngle other)
```

#### Parameters

`other` [CSVCMsg\_CrosshairAngle](Divine.Protobufs.Dota2.CSVCMsg\_CrosshairAngle.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle_"></a> MergeFrom\(CSVCMsg\_CrosshairAngle\)

```csharp
public void MergeFrom(CSVCMsg_CrosshairAngle other)
```

#### Parameters

`other` [CSVCMsg\_CrosshairAngle](Divine.Protobufs.Dota2.CSVCMsg\_CrosshairAngle.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_CrosshairAngle_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

